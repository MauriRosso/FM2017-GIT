namespace Football_Manager_2016
{
    partial class Calendario
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
            this.ptbCalendario = new System.Windows.Forms.MonthCalendar();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.ptbEscudoLocal = new System.Windows.Forms.PictureBox();
            this.ptbEscudoVisitante = new System.Windows.Forms.PictureBox();
            this.lblVS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEscudoLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEscudoVisitante)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCalendario
            // 
            this.ptbCalendario.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.ptbCalendario.Location = new System.Drawing.Point(0, 0);
            this.ptbCalendario.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.ptbCalendario.Name = "ptbCalendario";
            this.ptbCalendario.ShowToday = false;
            this.ptbCalendario.TabIndex = 0;
            this.ptbCalendario.TitleForeColor = System.Drawing.Color.Black;
            this.ptbCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ptbCalendario_DateChanged);
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaActual.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.Color.Black;
            this.lblFechaActual.Location = new System.Drawing.Point(189, 320);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(171, 35);
            this.lblFechaActual.TabIndex = 73;
            this.lblFechaActual.Text = "aaaa/mm/dd";
            // 
            // ptbEscudoLocal
            // 
            this.ptbEscudoLocal.Location = new System.Drawing.Point(221, 381);
            this.ptbEscudoLocal.Name = "ptbEscudoLocal";
            this.ptbEscudoLocal.Size = new System.Drawing.Size(92, 88);
            this.ptbEscudoLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEscudoLocal.TabIndex = 80;
            this.ptbEscudoLocal.TabStop = false;
            // 
            // ptbEscudoVisitante
            // 
            this.ptbEscudoVisitante.Location = new System.Drawing.Point(420, 381);
            this.ptbEscudoVisitante.Name = "ptbEscudoVisitante";
            this.ptbEscudoVisitante.Size = new System.Drawing.Size(92, 88);
            this.ptbEscudoVisitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEscudoVisitante.TabIndex = 81;
            this.ptbEscudoVisitante.TabStop = false;
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.Location = new System.Drawing.Point(340, 408);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(53, 31);
            this.lblVS.TabIndex = 79;
            this.lblVS.Text = "VS";
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(751, 497);
            this.Controls.Add(this.ptbEscudoLocal);
            this.Controls.Add(this.ptbEscudoVisitante);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblFechaActual);
            this.Controls.Add(this.ptbCalendario);
            this.Name = "Calendario";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Calendario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEscudoLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEscudoVisitante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar ptbCalendario;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.PictureBox ptbEscudoLocal;
        private System.Windows.Forms.PictureBox ptbEscudoVisitante;
        private System.Windows.Forms.Label lblVS;
    }
}