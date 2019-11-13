namespace Generar_Reporte_de_Tiempos_de_Intervención
{
    partial class PantallaInformeTiemposIntervencion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInformeTiemposIntervencion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaHoraDesde = new System.Windows.Forms.DateTimePicker();
            this.dtFechaHoraHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ckListGravedades = new System.Windows.Forms.CheckedListBox();
            this.ckListTipoSiniestro = new System.Windows.Forms.CheckedListBox();
            this.rdDuracion = new System.Windows.Forms.RadioButton();
            this.rdRespuesta = new System.Windows.Forms.RadioButton();
            this.rdCierre = new System.Windows.Forms.RadioButton();
            this.pnlTiempo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "y por Tipo de Siniestro...";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gravedades...";
            // 
            // dtFechaHoraDesde
            // 
            this.dtFechaHoraDesde.CustomFormat = "dd/MM/yyyy  hh:mm:ss";
            this.dtFechaHoraDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaHoraDesde.Location = new System.Drawing.Point(277, 120);
            this.dtFechaHoraDesde.MaxDate = new System.DateTime(2019, 11, 7, 0, 0, 0, 0);
            this.dtFechaHoraDesde.Name = "dtFechaHoraDesde";
            this.dtFechaHoraDesde.Size = new System.Drawing.Size(213, 22);
            this.dtFechaHoraDesde.TabIndex = 6;
            this.dtFechaHoraDesde.Value = new System.DateTime(2019, 8, 1, 0, 0, 0, 0);
            // 
            // dtFechaHoraHasta
            // 
            this.dtFechaHoraHasta.CustomFormat = "dd/MM/yyyy - hh:mm:ss";
            this.dtFechaHoraHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaHoraHasta.Location = new System.Drawing.Point(589, 120);
            this.dtFechaHoraHasta.MaxDate = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            this.dtFechaHoraHasta.Name = "dtFechaHoraHasta";
            this.dtFechaHoraHasta.Size = new System.Drawing.Size(212, 22);
            this.dtFechaHoraHasta.TabIndex = 7;
            this.dtFechaHoraHasta.Value = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Con intervenciones desde el";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "hasta el";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(26, 451);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(203, 67);
            this.btnGenerarReporte.TabIndex = 10;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(611, 451);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(177, 67);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(444, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Generar Reporte de Tiempos de Intervención";
            // 
            // ckListGravedades
            // 
            this.ckListGravedades.FormattingEnabled = true;
            this.ckListGravedades.Location = new System.Drawing.Point(148, 214);
            this.ckListGravedades.Name = "ckListGravedades";
            this.ckListGravedades.Size = new System.Drawing.Size(204, 89);
            this.ckListGravedades.TabIndex = 15;
            // 
            // ckListTipoSiniestro
            // 
            this.ckListTipoSiniestro.FormattingEnabled = true;
            this.ckListTipoSiniestro.Location = new System.Drawing.Point(611, 214);
            this.ckListTipoSiniestro.Name = "ckListTipoSiniestro";
            this.ckListTipoSiniestro.Size = new System.Drawing.Size(195, 89);
            this.ckListTipoSiniestro.TabIndex = 16;
            this.ckListTipoSiniestro.ThreeDCheckBoxes = true;
            // 
            // rdDuracion
            // 
            this.rdDuracion.AutoSize = true;
            this.rdDuracion.Checked = true;
            this.rdDuracion.Location = new System.Drawing.Point(265, 30);
            this.rdDuracion.Name = "rdDuracion";
            this.rdDuracion.Size = new System.Drawing.Size(86, 21);
            this.rdDuracion.TabIndex = 17;
            this.rdDuracion.TabStop = true;
            this.rdDuracion.Text = "Duración";
            this.rdDuracion.UseVisualStyleBackColor = true;
            // 
            // rdRespuesta
            // 
            this.rdRespuesta.AutoSize = true;
            this.rdRespuesta.Location = new System.Drawing.Point(460, 30);
            this.rdRespuesta.Name = "rdRespuesta";
            this.rdRespuesta.Size = new System.Drawing.Size(97, 21);
            this.rdRespuesta.TabIndex = 18;
            this.rdRespuesta.Text = "Respuesta";
            this.rdRespuesta.UseVisualStyleBackColor = true;
            // 
            // rdCierre
            // 
            this.rdCierre.AutoSize = true;
            this.rdCierre.Location = new System.Drawing.Point(657, 30);
            this.rdCierre.Name = "rdCierre";
            this.rdCierre.Size = new System.Drawing.Size(67, 21);
            this.rdCierre.TabIndex = 19;
            this.rdCierre.Text = "Cierre";
            this.rdCierre.UseVisualStyleBackColor = true;
            this.rdCierre.CheckedChanged += new System.EventHandler(this.rdCierre_CheckedChanged);
            // 
            // pnlTiempo
            // 
            this.pnlTiempo.Controls.Add(this.button1);
            this.pnlTiempo.Controls.Add(this.rdRespuesta);
            this.pnlTiempo.Controls.Add(this.label8);
            this.pnlTiempo.Controls.Add(this.rdCierre);
            this.pnlTiempo.Controls.Add(this.rdDuracion);
            this.pnlTiempo.Location = new System.Drawing.Point(20, 328);
            this.pnlTiempo.Name = "pnlTiempo";
            this.pnlTiempo.Size = new System.Drawing.Size(781, 83);
            this.pnlTiempo.TabIndex = 20;
            this.pnlTiempo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTiempo_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 24;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 42);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tiempo de Intervencion";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Periodo ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Filtrar Por";
            // 
            // PantallaInformeTiemposIntervencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(837, 543);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlTiempo);
            this.Controls.Add(this.ckListTipoSiniestro);
            this.Controls.Add(this.ckListGravedades);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtFechaHoraHasta);
            this.Controls.Add(this.dtFechaHoraDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaInformeTiemposIntervencion";
            this.Text = "Generar Reporte de Tiempos de Intervencion";
            this.Load += new System.EventHandler(this.HabilitarPantalla);
            this.pnlTiempo.ResumeLayout(false);
            this.pnlTiempo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaHoraDesde;
        private System.Windows.Forms.DateTimePicker dtFechaHoraHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox ckListGravedades;
        private System.Windows.Forms.CheckedListBox ckListTipoSiniestro;
        private System.Windows.Forms.RadioButton rdDuracion;
        private System.Windows.Forms.RadioButton rdRespuesta;
        private System.Windows.Forms.RadioButton rdCierre;
        private System.Windows.Forms.Panel pnlTiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

