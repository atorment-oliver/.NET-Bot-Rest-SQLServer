
namespace Robot
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpConfigTimer = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProcesarDia = new System.Windows.Forms.Label();
            this.nudPointPagination = new System.Windows.Forms.NumericUpDown();
            this.nudPointRecord = new System.Windows.Forms.NumericUpDown();
            this.nudProcesarTiempo = new System.Windows.Forms.NumericUpDown();
            this.nudProcesarDia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpConfigApis = new System.Windows.Forms.TabPage();
            this.txtWsCustomer = new System.Windows.Forms.TextBox();
            this.txtWsTso = new System.Windows.Forms.TextBox();
            this.txtWsTravelC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tpLogs = new System.Windows.Forms.TabPage();
            this.btnLocalFile = new System.Windows.Forms.Button();
            this.txtDireccionLocalFile = new System.Windows.Forms.TextBox();
            this.txtWsLog = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tpConfigKeysAioTso = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpConfigTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPagination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcesarTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcesarDia)).BeginInit();
            this.tpConfigApis.SuspendLayout();
            this.tpLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(178, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(119, 30);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 30);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 386);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpConfigTimer);
            this.tabControl1.Controls.Add(this.tpConfigApis);
            this.tabControl1.Controls.Add(this.tpLogs);
            this.tabControl1.Controls.Add(this.tpConfigKeysAioTso);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 386);
            this.tabControl1.TabIndex = 1;
            // 
            // tpConfigTimer
            // 
            this.tpConfigTimer.Controls.Add(this.label6);
            this.tpConfigTimer.Controls.Add(this.lblProcesarDia);
            this.tpConfigTimer.Controls.Add(this.nudPointPagination);
            this.tpConfigTimer.Controls.Add(this.nudPointRecord);
            this.tpConfigTimer.Controls.Add(this.nudProcesarTiempo);
            this.tpConfigTimer.Controls.Add(this.nudProcesarDia);
            this.tpConfigTimer.Controls.Add(this.label4);
            this.tpConfigTimer.Controls.Add(this.label3);
            this.tpConfigTimer.Controls.Add(this.label2);
            this.tpConfigTimer.Controls.Add(this.label1);
            this.tpConfigTimer.Location = new System.Drawing.Point(4, 25);
            this.tpConfigTimer.Name = "tpConfigTimer";
            this.tpConfigTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfigTimer.Size = new System.Drawing.Size(792, 357);
            this.tpConfigTimer.TabIndex = 0;
            this.tpConfigTimer.Text = "Reloj y Fecha";
            this.tpConfigTimer.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Segundos";
            // 
            // lblProcesarDia
            // 
            this.lblProcesarDia.AutoSize = true;
            this.lblProcesarDia.Location = new System.Drawing.Point(348, 35);
            this.lblProcesarDia.Name = "lblProcesarDia";
            this.lblProcesarDia.Size = new System.Drawing.Size(100, 17);
            this.lblProcesarDia.TabIndex = 8;
            this.lblProcesarDia.Text = "(Fecha Actual)";
            // 
            // nudPointPagination
            // 
            this.nudPointPagination.Location = new System.Drawing.Point(367, 205);
            this.nudPointPagination.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPointPagination.Name = "nudPointPagination";
            this.nudPointPagination.Size = new System.Drawing.Size(120, 22);
            this.nudPointPagination.TabIndex = 7;
            // 
            // nudPointRecord
            // 
            this.nudPointRecord.Location = new System.Drawing.Point(367, 165);
            this.nudPointRecord.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudPointRecord.Name = "nudPointRecord";
            this.nudPointRecord.Size = new System.Drawing.Size(120, 22);
            this.nudPointRecord.TabIndex = 6;
            // 
            // nudProcesarTiempo
            // 
            this.nudProcesarTiempo.Location = new System.Drawing.Point(207, 78);
            this.nudProcesarTiempo.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudProcesarTiempo.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudProcesarTiempo.Name = "nudProcesarTiempo";
            this.nudProcesarTiempo.Size = new System.Drawing.Size(120, 22);
            this.nudProcesarTiempo.TabIndex = 5;
            this.nudProcesarTiempo.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudProcesarDia
            // 
            this.nudProcesarDia.Location = new System.Drawing.Point(207, 32);
            this.nudProcesarDia.Minimum = new decimal(new int[] {
            29,
            0,
            0,
            -2147483648});
            this.nudProcesarDia.Name = "nudProcesarDia";
            this.nudProcesarDia.Size = new System.Drawing.Size(120, 22);
            this.nudProcesarDia.TabIndex = 4;
            this.nudProcesarDia.ValueChanged += new System.EventHandler(this.nudProcesarDia_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PUNTERO DE LA PAGINACION ACTUAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PUNTERO DE REGISTRO DE LECTURA ACTUAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "EJECUTAR ROBOT CADA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "FECHA A PROCESAR";
            // 
            // tpConfigApis
            // 
            this.tpConfigApis.Controls.Add(this.txtWsCustomer);
            this.tpConfigApis.Controls.Add(this.txtWsTso);
            this.tpConfigApis.Controls.Add(this.txtWsTravelC);
            this.tpConfigApis.Controls.Add(this.label8);
            this.tpConfigApis.Controls.Add(this.label7);
            this.tpConfigApis.Controls.Add(this.label5);
            this.tpConfigApis.Location = new System.Drawing.Point(4, 25);
            this.tpConfigApis.Name = "tpConfigApis";
            this.tpConfigApis.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfigApis.Size = new System.Drawing.Size(792, 357);
            this.tpConfigApis.TabIndex = 1;
            this.tpConfigApis.Text = "Rutas de Apis";
            this.tpConfigApis.UseVisualStyleBackColor = true;
            // 
            // txtWsCustomer
            // 
            this.txtWsCustomer.Location = new System.Drawing.Point(33, 191);
            this.txtWsCustomer.Name = "txtWsCustomer";
            this.txtWsCustomer.Size = new System.Drawing.Size(726, 22);
            this.txtWsCustomer.TabIndex = 5;
            // 
            // txtWsTso
            // 
            this.txtWsTso.Location = new System.Drawing.Point(33, 120);
            this.txtWsTso.Name = "txtWsTso";
            this.txtWsTso.Size = new System.Drawing.Size(726, 22);
            this.txtWsTso.TabIndex = 4;
            // 
            // txtWsTravelC
            // 
            this.txtWsTravelC.Location = new System.Drawing.Point(33, 52);
            this.txtWsTravelC.Name = "txtWsTravelC";
            this.txtWsTravelC.Size = new System.Drawing.Size(726, 22);
            this.txtWsTravelC.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "RUTA API CLIENTES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "RUTA API TSO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "RUTA API TRAVEL-C";
            // 
            // tpLogs
            // 
            this.tpLogs.Controls.Add(this.btnLocalFile);
            this.tpLogs.Controls.Add(this.txtDireccionLocalFile);
            this.tpLogs.Controls.Add(this.txtWsLog);
            this.tpLogs.Controls.Add(this.label10);
            this.tpLogs.Controls.Add(this.label9);
            this.tpLogs.Location = new System.Drawing.Point(4, 25);
            this.tpLogs.Name = "tpLogs";
            this.tpLogs.Size = new System.Drawing.Size(792, 357);
            this.tpLogs.TabIndex = 3;
            this.tpLogs.Text = "Log y Archivos TTL\'s";
            this.tpLogs.UseVisualStyleBackColor = true;
            // 
            // btnLocalFile
            // 
            this.btnLocalFile.Location = new System.Drawing.Point(661, 120);
            this.btnLocalFile.Name = "btnLocalFile";
            this.btnLocalFile.Size = new System.Drawing.Size(105, 23);
            this.btnLocalFile.TabIndex = 4;
            this.btnLocalFile.Text = "EXPLORAR";
            this.btnLocalFile.UseVisualStyleBackColor = true;
            this.btnLocalFile.Click += new System.EventHandler(this.btnLocalFile_Click);
            // 
            // txtDireccionLocalFile
            // 
            this.txtDireccionLocalFile.Location = new System.Drawing.Point(32, 120);
            this.txtDireccionLocalFile.Name = "txtDireccionLocalFile";
            this.txtDireccionLocalFile.Size = new System.Drawing.Size(623, 22);
            this.txtDireccionLocalFile.TabIndex = 3;
            // 
            // txtWsLog
            // 
            this.txtWsLog.Location = new System.Drawing.Point(29, 46);
            this.txtWsLog.Name = "txtWsLog";
            this.txtWsLog.Size = new System.Drawing.Size(737, 22);
            this.txtWsLog.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "DIRECTORIO A DESCARGAR ARCHIVO TTL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "RUTA API LOG";
            // 
            // tpConfigKeysAioTso
            // 
            this.tpConfigKeysAioTso.Location = new System.Drawing.Point(4, 25);
            this.tpConfigKeysAioTso.Name = "tpConfigKeysAioTso";
            this.tpConfigKeysAioTso.Size = new System.Drawing.Size(792, 357);
            this.tpConfigKeysAioTso.TabIndex = 2;
            this.tpConfigKeysAioTso.Text = "Parametrizaciones";
            this.tpConfigKeysAioTso.UseVisualStyleBackColor = true;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmConfig";
            this.Text = "Configuraciones";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpConfigTimer.ResumeLayout(false);
            this.tpConfigTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointPagination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcesarTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcesarDia)).EndInit();
            this.tpConfigApis.ResumeLayout(false);
            this.tpConfigApis.PerformLayout();
            this.tpLogs.ResumeLayout(false);
            this.tpLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpConfigTimer;
        private System.Windows.Forms.TabPage tpConfigApis;
        private System.Windows.Forms.TabPage tpConfigKeysAioTso;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPointPagination;
        private System.Windows.Forms.NumericUpDown nudPointRecord;
        private System.Windows.Forms.NumericUpDown nudProcesarTiempo;
        private System.Windows.Forms.NumericUpDown nudProcesarDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProcesarDia;
        private System.Windows.Forms.TextBox txtWsCustomer;
        private System.Windows.Forms.TextBox txtWsTso;
        private System.Windows.Forms.TextBox txtWsTravelC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpLogs;
        private System.Windows.Forms.Button btnLocalFile;
        private System.Windows.Forms.TextBox txtDireccionLocalFile;
        private System.Windows.Forms.TextBox txtWsLog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}