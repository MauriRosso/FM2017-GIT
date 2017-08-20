namespace Football_Manager_2016
{
    partial class Configurar_Juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurar_Juego));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConfigurarFixture = new System.Windows.Forms.Button();
            this.btnConfigEquipos = new System.Windows.Forms.Button();
            this.btnConfigJugadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 522);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConfigurarFixture
            // 
            this.btnConfigurarFixture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfigurarFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarFixture.Location = new System.Drawing.Point(122, 100);
            this.btnConfigurarFixture.Name = "btnConfigurarFixture";
            this.btnConfigurarFixture.Size = new System.Drawing.Size(225, 41);
            this.btnConfigurarFixture.TabIndex = 1;
            this.btnConfigurarFixture.Text = "Configurar Fixture";
            this.btnConfigurarFixture.UseVisualStyleBackColor = false;
            this.btnConfigurarFixture.Click += new System.EventHandler(this.btnConfigurarFixture_Click);
            // 
            // btnConfigEquipos
            // 
            this.btnConfigEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfigEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigEquipos.Location = new System.Drawing.Point(122, 234);
            this.btnConfigEquipos.Name = "btnConfigEquipos";
            this.btnConfigEquipos.Size = new System.Drawing.Size(225, 41);
            this.btnConfigEquipos.TabIndex = 2;
            this.btnConfigEquipos.Text = "Configurar Equipos";
            this.btnConfigEquipos.UseVisualStyleBackColor = false;
            this.btnConfigEquipos.Click += new System.EventHandler(this.btnConfigEquipos_Click);
            // 
            // btnConfigJugadores
            // 
            this.btnConfigJugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnConfigJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigJugadores.Location = new System.Drawing.Point(122, 364);
            this.btnConfigJugadores.Name = "btnConfigJugadores";
            this.btnConfigJugadores.Size = new System.Drawing.Size(225, 41);
            this.btnConfigJugadores.TabIndex = 3;
            this.btnConfigJugadores.Text = "Configurar Jugadores";
            this.btnConfigJugadores.UseVisualStyleBackColor = false;
            this.btnConfigJugadores.Click += new System.EventHandler(this.btnConfigJugadores_Click);
            // 
            // Configurar_Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 519);
            this.Controls.Add(this.btnConfigJugadores);
            this.Controls.Add(this.btnConfigEquipos);
            this.Controls.Add(this.btnConfigurarFixture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Configurar_Juego";
            this.Text = "Configurar_Juego";
            this.Load += new System.EventHandler(this.Configurar_Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConfigurarFixture;
        private System.Windows.Forms.Button btnConfigEquipos;
        private System.Windows.Forms.Button btnConfigJugadores;
    }
}