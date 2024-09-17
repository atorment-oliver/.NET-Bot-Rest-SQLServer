using System;
using System.Windows.Forms;

namespace Robot
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            try
            {
                //lee los datos del xml y los carga en el form
                RoutesFiles oRoutesFiles = new RoutesFiles();
                Utilities oUtilities = new Utilities();
                oRoutesFiles = oUtilities.LoadXML(Application.StartupPath);

                this.txtWsTso.Text = oRoutesFiles.PathWsTso;
                this.txtWsTravelC.Text = oRoutesFiles.PathWsTravelC;
                this.txtWsCustomer.Text = oRoutesFiles.PathWsCustomer;
                this.txtWsLog.Text = oRoutesFiles.PathWsLog;
                this.txtDireccionLocalFile.Text = oRoutesFiles.PathLocalFile;

                if (oRoutesFiles.ExecDay != null) this.nudProcesarDia.Value = Convert.ToDecimal(oRoutesFiles.ExecDay);
                if (oRoutesFiles.ExecTime != null) this.nudProcesarTiempo.Value = Convert.ToDecimal(oRoutesFiles.ExecTime);

                //lee los datos del prop config del app y los carga en el form
                var prop = Robot.Properties.Settings.Default;
                this.nudPointRecord.Value = prop.point_tt + 1;
                this.nudPointPagination.Value = prop.pag_tt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateField())
            {
                try
                {
                    //guarda los datos en el file de config xml
                    var blnSave = new Utilities().saveConfiguration(Application.StartupPath,
                        new RoutesFiles
                        {
                            ExecDay = nudProcesarDia.Value.ToString(),
                            ExecTime = nudProcesarTiempo.Value.ToString(),
                            LogJson = txtWsLog.Text,
                            PathWsTravelC = txtWsTravelC.Text,
                            PathWsTso = txtWsTso.Text,
                            PathWsCustomer = txtWsCustomer.Text,
                            PathWsLog = txtWsLog.Text,
                            PathLocalFile = txtDireccionLocalFile.Text
                        }
                        );

                    //guarda los datos en el config de la app
                    var prop = Robot.Properties.Settings.Default;
                    prop.point_tt = Convert.ToInt16(this.nudPointRecord.Value) - 1;
                    prop.pag_tt = Convert.ToInt16(this.nudPointPagination.Value);
                    prop.Save();

                    if (blnSave)
                    {
                        MessageBox.Show("Se ha guardado su configuración con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalFile_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.Description = "Ruta almacenamiento File Travel";

            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtDireccionLocalFile.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void nudProcesarDia_ValueChanged(object sender, EventArgs e)
        {
            var i = Convert.ToDouble(((NumericUpDown)sender).Value);
            lblProcesarDia.Text = string.Format("( {0} )", (i == 0 ? "Fecha Actual" : DateTime.Now.AddDays(i).ToLongDateString()));
        }

        private bool ValidateField()
        {
            string sResult = string.Empty;
            bool blnValidate = true;

            if (this.txtWsCustomer.Text.Length == 0)
            {
                sResult += "Falta ingresar ruta del servicio web cliente" + System.Environment.NewLine;
                blnValidate = false;
            }

            if (this.txtWsTso.Text.Length == 0)
            {
                sResult += "Falta ingresar ruta del servicio web tso" + System.Environment.NewLine;
                blnValidate = false;
            }

            if (this.txtWsTravelC.Text.Length == 0)
            {
                sResult += "Falta ingresar ruta del servicio web travel c" + System.Environment.NewLine;
                blnValidate = false;
            }

            if (this.txtWsLog.Text.Length == 0)
            {
                sResult += "Falta ingresar la ruta del servicio web Log" + System.Environment.NewLine;
                blnValidate = false;
            }
            if (this.txtDireccionLocalFile.Text.Length == 0)
            {
                sResult += "Falta ingresar direccion para registro del file" + System.Environment.NewLine;
                blnValidate = false;
            }

            if (!blnValidate)
            {
                MessageBox.Show(sResult, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return blnValidate;
        }
    }
}
