namespace Football_Manager_2016
{
    partial class Partidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Partidas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrillaPartidas = new System.Windows.Forms.DataGridView();
            this.btnNuevaPartida = new System.Windows.Forms.Button();
            this.btnCargarPartida = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVolverAlPrincipio = new System.Windows.Forms.Button();
            this.NombreEntrenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacionPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GrillaPartidas
            // 
            this.GrillaPartidas.AllowUserToAddRows = false;
            this.GrillaPartidas.AllowUserToDeleteRows = false;
            this.GrillaPartidas.AllowUserToResizeColumns = false;
            this.GrillaPartidas.AllowUserToResizeRows = false;
            this.GrillaPartidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GrillaPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEntrenador,
            this.EquipoPartida,
            this.FechaCreacionPartida});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaPartidas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaPartidas.GridColor = System.Drawing.Color.Red;
            this.GrillaPartidas.Location = new System.Drawing.Point(451, 97);
            this.GrillaPartidas.Name = "GrillaPartidas";
            this.GrillaPartidas.RowHeadersVisible = false;
            this.GrillaPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaPartidas.Size = new System.Drawing.Size(462, 320);
            this.GrillaPartidas.TabIndex = 1;
            // 
            // btnNuevaPartida
            // 
            this.btnNuevaPartida.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaPartida.Location = new System.Drawing.Point(139, 74);
            this.btnNuevaPartida.Name = "btnNuevaPartida";
            this.btnNuevaPartida.Size = new System.Drawing.Size(170, 52);
            this.btnNuevaPartida.TabIndex = 2;
            this.btnNuevaPartida.Text = "Nueva Partida";
            this.btnNuevaPartida.UseVisualStyleBackColor = false;
            this.btnNuevaPartida.Click += new System.EventHandler(this.btnNuevaPartida_Click);
            // 
            // btnCargarPartida
            // 
            this.btnCargarPartida.BackColor = System.Drawing.Color.Yellow;
            this.btnCargarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarPartida.Location = new System.Drawing.Point(139, 184);
            this.btnCargarPartida.Name = "btnCargarPartida";
            this.btnCargarPartida.Size = new System.Drawing.Size(170, 52);
            this.btnCargarPartida.TabIndex = 3;
            this.btnCargarPartida.Text = "Cargar Partida";
            this.btnCargarPartida.UseVisualStyleBackColor = false;
            this.btnCargarPartida.Click += new System.EventHandler(this.btnCargarPartida_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(139, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Borrar Partida";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(139, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Borrar Todas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVolverAlPrincipio
            // 
            this.btnVolverAlPrincipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolverAlPrincipio.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverAlPrincipio.Image")));
            this.btnVolverAlPrincipio.Location = new System.Drawing.Point(12, 463);
            this.btnVolverAlPrincipio.Name = "btnVolverAlPrincipio";
            this.btnVolverAlPrincipio.Size = new System.Drawing.Size(68, 50);
            this.btnVolverAlPrincipio.TabIndex = 6;
            this.btnVolverAlPrincipio.UseVisualStyleBackColor = false;
            this.btnVolverAlPrincipio.Click += new System.EventHandler(this.btnVolverAlPrincipio_Click);
            // 
            // NombreEntrenador
            // 
            this.NombreEntrenador.Frozen = true;
            this.NombreEntrenador.HeaderText = "Nombre entrenador";
            this.NombreEntrenador.Name = "NombreEntrenador";
            this.NombreEntrenador.ReadOnly = true;
            this.NombreEntrenador.Width = 150;
            // 
            // EquipoPartida
            // 
            this.EquipoPartida.Frozen = true;
            this.EquipoPartida.HeaderText = "Equipo";
            this.EquipoPartida.Name = "EquipoPartida";
            this.EquipoPartida.ReadOnly = true;
            this.EquipoPartida.Width = 140;
            // 
            // FechaCreacionPartida
            // 
            this.FechaCreacionPartida.Frozen = true;
            this.FechaCreacionPartida.HeaderText = "Fecha de creación";
            this.FechaCreacionPartida.Name = "FechaCreacionPartida";
            this.FechaCreacionPartida.ReadOnly = true;
            this.FechaCreacionPartida.Width = 170;
            // 
            // Partidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 525);
            this.Controls.Add(this.btnVolverAlPrincipio);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCargarPartida);
            this.Controls.Add(this.btnNuevaPartida);
            this.Controls.Add(this.GrillaPartidas);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Partidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidas";
            this.Load += new System.EventHandler(this.Partidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPartidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView GrillaPartidas;
        private System.Windows.Forms.Button btnNuevaPartida;
        private System.Windows.Forms.Button btnCargarPartida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnVolverAlPrincipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEntrenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacionPartida;
    }
}