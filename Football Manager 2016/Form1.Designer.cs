namespace Football_Manager_2016
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ptbFondoFootball = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnVerEquipos = new System.Windows.Forms.Button();
            this.btnVerLigas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.ptbFootMan2017 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFondoFootball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFootMan2017)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFondoFootball
            // 
            this.ptbFondoFootball.Image = ((System.Drawing.Image)(resources.GetObject("ptbFondoFootball.Image")));
            this.ptbFondoFootball.Location = new System.Drawing.Point(0, 0);
            this.ptbFondoFootball.Name = "ptbFondoFootball";
            this.ptbFondoFootball.Size = new System.Drawing.Size(1143, 714);
            this.ptbFondoFootball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFondoFootball.TabIndex = 0;
            this.ptbFondoFootball.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnJugar.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Image = ((System.Drawing.Image)(resources.GetObject("btnJugar.Image")));
            this.btnJugar.Location = new System.Drawing.Point(903, 590);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(200, 94);
            this.btnJugar.TabIndex = 2;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnVerEquipos
            // 
            this.btnVerEquipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerEquipos.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEquipos.Image = ((System.Drawing.Image)(resources.GetObject("btnVerEquipos.Image")));
            this.btnVerEquipos.Location = new System.Drawing.Point(678, 590);
            this.btnVerEquipos.Name = "btnVerEquipos";
            this.btnVerEquipos.Size = new System.Drawing.Size(200, 94);
            this.btnVerEquipos.TabIndex = 3;
            this.btnVerEquipos.Text = "VER EQUIPOS";
            this.btnVerEquipos.UseVisualStyleBackColor = false;
            this.btnVerEquipos.Click += new System.EventHandler(this.btnVerEquipos_Click);
            // 
            // btnVerLigas
            // 
            this.btnVerLigas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerLigas.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerLigas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerLigas.Image")));
            this.btnVerLigas.Location = new System.Drawing.Point(454, 590);
            this.btnVerLigas.Name = "btnVerLigas";
            this.btnVerLigas.Size = new System.Drawing.Size(200, 94);
            this.btnVerLigas.TabIndex = 4;
            this.btnVerLigas.Text = "VER LIGAS";
            this.btnVerLigas.UseVisualStyleBackColor = false;
            this.btnVerLigas.Click += new System.EventHandler(this.btnVerLigas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(12, 590);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 94);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfiguracion.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Image")));
            this.btnConfiguracion.Location = new System.Drawing.Point(233, 590);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(200, 94);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "CONFIGURAR";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // ptbFootMan2017
            // 
            this.ptbFootMan2017.Image = ((System.Drawing.Image)(resources.GetObject("ptbFootMan2017.Image")));
            this.ptbFootMan2017.Location = new System.Drawing.Point(48, 54);
            this.ptbFootMan2017.Name = "ptbFootMan2017";
            this.ptbFootMan2017.Size = new System.Drawing.Size(708, 286);
            this.ptbFootMan2017.TabIndex = 7;
            this.ptbFootMan2017.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 695);
            this.Controls.Add(this.ptbFootMan2017);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerLigas);
            this.Controls.Add(this.btnVerEquipos);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.ptbFondoFootball);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1131, 734);
            this.MinimumSize = new System.Drawing.Size(1131, 726);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFondoFootball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFootMan2017)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFondoFootball;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnVerEquipos;
        private System.Windows.Forms.Button btnVerLigas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.PictureBox ptbFootMan2017;
    }
}

