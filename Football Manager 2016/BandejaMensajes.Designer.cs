namespace Football_Manager_2016
{
    partial class BandejaMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandejaMensajes));
            this.GrillaMensajes = new System.Windows.Forms.DataGridView();
            this.GrillaMensajesIcono = new System.Windows.Forms.DataGridViewImageColumn();
            this.GrillaMensajesTilde = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GrillaMensajesAsunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaMensajesEmisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaMensajesFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBandejaDeMensajes = new System.Windows.Forms.Label();
            this.ptbMensajes = new System.Windows.Forms.PictureBox();
            this.txtCuerpoMensaje = new System.Windows.Forms.TextBox();
            this.btnCerrarBandejaMensajes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMensajes)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaMensajes
            // 
            this.GrillaMensajes.AllowUserToAddRows = false;
            this.GrillaMensajes.AllowUserToDeleteRows = false;
            this.GrillaMensajes.AllowUserToResizeColumns = false;
            this.GrillaMensajes.AllowUserToResizeRows = false;
            this.GrillaMensajes.BackgroundColor = System.Drawing.Color.Gray;
            this.GrillaMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMensajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GrillaMensajesIcono,
            this.GrillaMensajesTilde,
            this.GrillaMensajesAsunto,
            this.GrillaMensajesEmisor,
            this.GrillaMensajesFecha});
            this.GrillaMensajes.Location = new System.Drawing.Point(12, 105);
            this.GrillaMensajes.Name = "GrillaMensajes";
            this.GrillaMensajes.RowHeadersVisible = false;
            this.GrillaMensajes.RowTemplate.Height = 35;
            this.GrillaMensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaMensajes.Size = new System.Drawing.Size(702, 289);
            this.GrillaMensajes.TabIndex = 0;
            this.GrillaMensajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaMensajes_CellContentClick);
            // 
            // GrillaMensajesIcono
            // 
            this.GrillaMensajesIcono.Frozen = true;
            this.GrillaMensajesIcono.HeaderText = "";
            this.GrillaMensajesIcono.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.GrillaMensajesIcono.Name = "GrillaMensajesIcono";
            this.GrillaMensajesIcono.ReadOnly = true;
            this.GrillaMensajesIcono.Width = 35;
            // 
            // GrillaMensajesTilde
            // 
            this.GrillaMensajesTilde.Frozen = true;
            this.GrillaMensajesTilde.HeaderText = "";
            this.GrillaMensajesTilde.Name = "GrillaMensajesTilde";
            this.GrillaMensajesTilde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaMensajesTilde.Width = 25;
            // 
            // GrillaMensajesAsunto
            // 
            this.GrillaMensajesAsunto.Frozen = true;
            this.GrillaMensajesAsunto.HeaderText = "Asunto";
            this.GrillaMensajesAsunto.Name = "GrillaMensajesAsunto";
            this.GrillaMensajesAsunto.ReadOnly = true;
            this.GrillaMensajesAsunto.Width = 300;
            // 
            // GrillaMensajesEmisor
            // 
            this.GrillaMensajesEmisor.Frozen = true;
            this.GrillaMensajesEmisor.HeaderText = "Emisor";
            this.GrillaMensajesEmisor.Name = "GrillaMensajesEmisor";
            this.GrillaMensajesEmisor.ReadOnly = true;
            this.GrillaMensajesEmisor.Width = 225;
            // 
            // GrillaMensajesFecha
            // 
            this.GrillaMensajesFecha.Frozen = true;
            this.GrillaMensajesFecha.HeaderText = "Fecha";
            this.GrillaMensajesFecha.Name = "GrillaMensajesFecha";
            this.GrillaMensajesFecha.ReadOnly = true;
            // 
            // lblBandejaDeMensajes
            // 
            this.lblBandejaDeMensajes.AutoSize = true;
            this.lblBandejaDeMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBandejaDeMensajes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBandejaDeMensajes.Location = new System.Drawing.Point(263, 43);
            this.lblBandejaDeMensajes.Name = "lblBandejaDeMensajes";
            this.lblBandejaDeMensajes.Size = new System.Drawing.Size(265, 29);
            this.lblBandejaDeMensajes.TabIndex = 7;
            this.lblBandejaDeMensajes.Text = "Bandeja de mensajes";
            // 
            // ptbMensajes
            // 
            this.ptbMensajes.Image = ((System.Drawing.Image)(resources.GetObject("ptbMensajes.Image")));
            this.ptbMensajes.Location = new System.Drawing.Point(157, 24);
            this.ptbMensajes.Name = "ptbMensajes";
            this.ptbMensajes.Size = new System.Drawing.Size(75, 64);
            this.ptbMensajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMensajes.TabIndex = 8;
            this.ptbMensajes.TabStop = false;
            // 
            // txtCuerpoMensaje
            // 
            this.txtCuerpoMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCuerpoMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuerpoMensaje.Location = new System.Drawing.Point(13, 409);
            this.txtCuerpoMensaje.Multiline = true;
            this.txtCuerpoMensaje.Name = "txtCuerpoMensaje";
            this.txtCuerpoMensaje.Size = new System.Drawing.Size(701, 118);
            this.txtCuerpoMensaje.TabIndex = 9;
            // 
            // btnCerrarBandejaMensajes
            // 
            this.btnCerrarBandejaMensajes.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarBandejaMensajes.Image")));
            this.btnCerrarBandejaMensajes.Location = new System.Drawing.Point(673, 12);
            this.btnCerrarBandejaMensajes.Name = "btnCerrarBandejaMensajes";
            this.btnCerrarBandejaMensajes.Size = new System.Drawing.Size(41, 39);
            this.btnCerrarBandejaMensajes.TabIndex = 29;
            this.btnCerrarBandejaMensajes.UseVisualStyleBackColor = true;
            this.btnCerrarBandejaMensajes.Click += new System.EventHandler(this.btnCerrarBandejaMensajes_Click);
            // 
            // BandejaMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(726, 539);
            this.Controls.Add(this.btnCerrarBandejaMensajes);
            this.Controls.Add(this.txtCuerpoMensaje);
            this.Controls.Add(this.ptbMensajes);
            this.Controls.Add(this.lblBandejaDeMensajes);
            this.Controls.Add(this.GrillaMensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BandejaMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BandejaMensajes";
            this.Load += new System.EventHandler(this.BandejaMensajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMensajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaMensajes;
        private System.Windows.Forms.Label lblBandejaDeMensajes;
        private System.Windows.Forms.PictureBox ptbMensajes;
        private System.Windows.Forms.TextBox txtCuerpoMensaje;
        private System.Windows.Forms.DataGridViewImageColumn GrillaMensajesIcono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GrillaMensajesTilde;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrillaMensajesAsunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrillaMensajesEmisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrillaMensajesFecha;
        private System.Windows.Forms.Button btnCerrarBandejaMensajes;
    }
}