using AIO.Api.TRAVELC;
using log4net;
using log4net.Config;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Robot
{
    public partial class frmMain : Form
    {
        private const string formatDate = "yyyyMMdd";
        private const string strTitulo = "AIO - Robot Integrador";
        //private static readonly ILog logger = LogManager.GetLogger(typeof(frmMain));
        private short pointErrorCritical;
        private const short maxErrorCritical = 0;
        private JsonSerializerSettings settings;
        private RoutesFiles oRoutesFiles = new RoutesFiles();
        private Authentication oAuthentication;
        private Bookings oBookings;

        public frmMain()
        {
            InitializeComponent();

            settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            };
            settings.Converters.Add(new Newtonsoft.Json.Converters.IsoDateTimeConverter() { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" });

            //logger = LogManager.GetLogger(typeof(frmMain));
            XmlConfigurator.Configure();

            //var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            //XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            //logger.Info("Iniciando el robot");

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            tsslVersion.Text = string.Format(this.tsslVersion.Text, version.Major, version.Minor, version.Build, version.Revision);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                var prop = Robot.Properties.Settings.Default;

                this.Visible = false;
                Utilities oUtilities = new Utilities();
                oRoutesFiles = oUtilities.LoadXML(Application.StartupPath);

                notificator(title: strTitulo, text: "Iniciando robot.", tip: 1000);

                //this.Visible = false;

                pointErrorCritical = 0;

                oAuthentication = new Authentication(UserName: prop.auth_tt_user, Password: prop.auth_tt_pass, MicroSiteId: prop.auth_tt_microsite, BaseUrl: oRoutesFiles.PathWsTravelC);

                ProcessRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                frmConfig objFor = new frmConfig();
                objFor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //Configuracion Menu Contextual
                ContextMenu oMenu = new System.Windows.Forms.ContextMenu();
                oMenu.MenuItems.Add("&Estado Actual", new EventHandler(ehRestore_Click));
                oMenu.MenuItems[0].DefaultItem = true;
                oMenu.MenuItems.Add("-");
                // Añadimos la opción de salir
                oMenu.MenuItems.Add("&Salir", new EventHandler(btnSalir_Click));

                // Asignar los valores para el NotifyIcon
                this.notifyIcon1.Icon = this.Icon;
                this.notifyIcon1.ContextMenu = oMenu;
                this.notifyIcon1.Text = "AIO - Integrador Cargado";
                this.notifyIcon1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ehRestore_Click(object sender, EventArgs e)
        {
            //Restaurar por si se minimizó
            // Este evento manejará tanto los eventos usados para Restaurar
            //El evento DoubleClick del NotifyIcon hay que asignarlo con Handles
            //Carga la pantalla para ver los botones y cambiar la configuración del sistema
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void notificator(string title, string text, int tip)
        {
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(tip);
        }

        private void StartTimeSync()
        {
            timer1.Interval = (Convert.ToInt32(oRoutesFiles.ExecTime) * 1000);
            timer1.Enabled = true;
        }

        private void StopTimeSync()
        {
            timer1.Enabled = false;
        }

        private void StartPointerRecord()
        {
            var prop = Robot.Properties.Settings.Default;

            if (prop.queryday_tt.Length == 0)
            {
                prop.Reset();
                prop.queryday_tt = DateTime.Now.ToString("dd/MM/yyyy");
                prop.Save();
            }
            else if (!prop.queryday_tt.Equals(DateTime.Now.ToString("dd/MM/yyyy")))
            {
                prop.Reset();
                prop.queryday_tt = DateTime.Now.ToString("dd/MM/yyyy");
                prop.Save();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            StartPointerRecord();
            ProcessRecords();
        }

        private void ProcessRecords()
        {
            var prop = Robot.Properties.Settings.Default;

            if (oBookings == null) oBookings = new Bookings(BaseUrl: oRoutesFiles.PathWsTravelC);

            try
            {
                StopTimeSync();

                var getDate = DateTime.Now.AddDays(Convert.ToDouble(oRoutesFiles.ExecDay)).ToString(formatDate);
                var first = 0;

                //En el caso que existe mas de una paginacion se calcula el primer indice 
                if (prop.pag_tt > 0) first = 100 * prop.pag_tt + 1;

                //OBTIENE UN NUEVO TOKEN DE TRAVEL-C
                var token = oAuthentication.Authenticate().token;

                var resultBooking = oBookings.GetBookings(AuthToken: token, Operator: prop.auth_tt_operator, From: getDate, To: getDate, First: first.ToString());

                //PROCESA LA RESPUESTA DEL API
                if (resultBooking.bookedTrip.Count > 0)
                {
                    notificator(title: strTitulo, text: "Preparando datos para la sincronización", tip: 1000);

                    var point = -1; //usado para controlar la paginacion

                    //RECORRE EL LIST. DEL "resultBooking.bookedTrip" A PROCESAR EN TSO
                    foreach (var bookedTrip in resultBooking.bookedTrip)
                    {
                        point += 1;

                        if (point > prop.point_tt)
                        {
                            string sBookedFile = JsonConvert.SerializeObject(bookedTrip);

                            //guarda el file del ttl leido
                            string path = (oRoutesFiles.PathLocalFile.Trim() + "\\" + bookedTrip.id);//ruta donde almacenar el file del ttl leido
                            using (StreamWriter writer = new StreamWriter(path))
                            {
                                writer.WriteLine(sBookedFile);
                                writer.Close();
                            }


                            //determina los servicios a procesar que tiene el ttl consultado
                            if (bookedTrip.carservice.Count > 0) { }
                            if (bookedTrip.closedtourservice.Count > 0) { }
                            if (bookedTrip.hotelservice.Count > 0) { }
                            if (bookedTrip.insuranceservice.Count > 0) { }
                            if (bookedTrip.manualservice.Count > 0) { }
                            if (bookedTrip.ticketservice.Count > 0) { }
                            if (bookedTrip.transferservice.Count > 0) { }
                            if (bookedTrip.transportservice.Count > 0) { }



                            prop.point_tt += 1; //indica el registro procesado x "insertService"
                            if (point == 99)
                            {
                                prop.pag_tt += 1; //cuando point = 99 indica que se debe realizar la sgte. paginacion                                
                                prop.point_tt = -1; //inicializar el puntero 
                            }
                            prop.Save();
                        }
                    }
                }

                //MessageBox.Show(token, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartTimeSync();

            }
            catch (Exception)
            {
                //logger.Error("ProcessRecords", ex);
                if (pointErrorCritical < maxErrorCritical)
                {
                    pointErrorCritical += 1;
                    StartTimeSync();
                }
                else
                {
                    MessageBox.Show("La aplicación se detuvo. Se llegó al máximo tope de errores por excepciones, revise el log.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    this.Dispose();
                }
            }
        }


    }
}
