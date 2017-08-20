namespace Football_Manager_2016
{
    partial class Estadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadio));
            this.ptbFondoEstadio = new System.Windows.Forms.PictureBox();
            this.ptbEstadioCancha = new System.Windows.Forms.PictureBox();
            this.btnEstadioAmpliar = new System.Windows.Forms.Button();
            this.lblEspectadores = new System.Windows.Forms.Label();
            this.lblEstadioCapacidad = new System.Windows.Forms.Label();
            this.lblEstCap = new System.Windows.Forms.Label();
            this.lblNombreEstadio = new System.Windows.Forms.Label();
            this.lblNomEst = new System.Windows.Forms.Label();
            this.lblEstadioNombreClub = new System.Windows.Forms.Label();
            this.lblEstadioNomClu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFondoEstadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEstadioCancha)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFondoEstadio
            // 
            this.ptbFondoEstadio.Image = ((System.Drawing.Image)(resources.GetObject("ptbFondoEstadio.Image")));
            this.ptbFondoEstadio.Location = new System.Drawing.Point(-2, 0);
            this.ptbFondoEstadio.Name = "ptbFondoEstadio";
            this.ptbFondoEstadio.Size = new System.Drawing.Size(619, 521);
            this.ptbFondoEstadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFondoEstadio.TabIndex = 0;
            this.ptbFondoEstadio.TabStop = false;
            this.ptbFondoEstadio.Click += new System.EventHandler(this.ptbFondoEstadio_Click);
            // 
            // ptbEstadioCancha
            // 
            this.ptbEstadioCancha.Location = new System.Drawing.Point(306, 268);
            this.ptbEstadioCancha.Name = "ptbEstadioCancha";
            this.ptbEstadioCancha.Size = new System.Drawing.Size(299, 220);
            this.ptbEstadioCancha.TabIndex = 7;
            this.ptbEstadioCancha.TabStop = false;
            // 
            // btnEstadioAmpliar
            // 
            this.btnEstadioAmpliar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEstadioAmpliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadioAmpliar.Location = new System.Drawing.Point(53, 341);
            this.btnEstadioAmpliar.Name = "btnEstadioAmpliar";
            this.btnEstadioAmpliar.Size = new System.Drawing.Size(173, 53);
            this.btnEstadioAmpliar.TabIndex = 8;
            this.btnEstadioAmpliar.Text = "Ampliar Estadio";
            this.btnEstadioAmpliar.UseVisualStyleBackColor = false;
            // 
            // lblEspectadores
            // 
            this.lblEspectadores.AutoSize = true;
            this.lblEspectadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEspectadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspectadores.ForeColor = System.Drawing.Color.Black;
            this.lblEspectadores.Location = new System.Drawing.Point(377, 187);
            this.lblEspectadores.Name = "lblEspectadores";
            this.lblEspectadores.Size = new System.Drawing.Size(136, 24);
            this.lblEspectadores.TabIndex = 16;
            this.lblEspectadores.Text = "espectadores";
            // 
            // lblEstadioCapacidad
            // 
            this.lblEstadioCapacidad.AutoSize = true;
            this.lblEstadioCapacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstadioCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadioCapacidad.ForeColor = System.Drawing.Color.Black;
            this.lblEstadioCapacidad.Location = new System.Drawing.Point(266, 187);
            this.lblEstadioCapacidad.Name = "lblEstadioCapacidad";
            this.lblEstadioCapacidad.Size = new System.Drawing.Size(123, 24);
            this.lblEstadioCapacidad.TabIndex = 15;
            this.lblEstadioCapacidad.Text = "(Capacidad)";
            // 
            // lblEstCap
            // 
            this.lblEstCap.AutoSize = true;
            this.lblEstCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstCap.ForeColor = System.Drawing.Color.Black;
            this.lblEstCap.Location = new System.Drawing.Point(125, 187);
            this.lblEstCap.Name = "lblEstCap";
            this.lblEstCap.Size = new System.Drawing.Size(115, 24);
            this.lblEstCap.TabIndex = 14;
            this.lblEstCap.Text = "Capacidad:";
            // 
            // lblNombreEstadio
            // 
            this.lblNombreEstadio.AutoSize = true;
            this.lblNombreEstadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstadio.ForeColor = System.Drawing.Color.Black;
            this.lblNombreEstadio.Location = new System.Drawing.Point(266, 120);
            this.lblNombreEstadio.Name = "lblNombreEstadio";
            this.lblNombreEstadio.Size = new System.Drawing.Size(93, 24);
            this.lblNombreEstadio.TabIndex = 13;
            this.lblNombreEstadio.Text = "(Estadio)";
            // 
            // lblNomEst
            // 
            this.lblNomEst.AutoSize = true;
            this.lblNomEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEst.ForeColor = System.Drawing.Color.Black;
            this.lblNomEst.Location = new System.Drawing.Point(74, 120);
            this.lblNomEst.Name = "lblNomEst";
            this.lblNomEst.Size = new System.Drawing.Size(166, 24);
            this.lblNomEst.TabIndex = 12;
            this.lblNomEst.Text = "Nombre Estadio:";
            // 
            // lblEstadioNombreClub
            // 
            this.lblEstadioNombreClub.AutoSize = true;
            this.lblEstadioNombreClub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstadioNombreClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadioNombreClub.ForeColor = System.Drawing.Color.Black;
            this.lblEstadioNombreClub.Location = new System.Drawing.Point(266, 56);
            this.lblEstadioNombreClub.Name = "lblEstadioNombreClub";
            this.lblEstadioNombreClub.Size = new System.Drawing.Size(67, 24);
            this.lblEstadioNombreClub.TabIndex = 11;
            this.lblEstadioNombreClub.Text = "(Club)";
            // 
            // lblEstadioNomClu
            // 
            this.lblEstadioNomClu.AutoSize = true;
            this.lblEstadioNomClu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstadioNomClu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadioNomClu.ForeColor = System.Drawing.Color.Black;
            this.lblEstadioNomClu.Location = new System.Drawing.Point(181, 56);
            this.lblEstadioNomClu.Name = "lblEstadioNomClu";
            this.lblEstadioNomClu.Size = new System.Drawing.Size(59, 24);
            this.lblEstadioNomClu.TabIndex = 10;
            this.lblEstadioNomClu.Text = "Club:";
            // 
            // Estadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 496);
            this.Controls.Add(this.lblEspectadores);
            this.Controls.Add(this.lblEstadioCapacidad);
            this.Controls.Add(this.lblEstCap);
            this.Controls.Add(this.lblNombreEstadio);
            this.Controls.Add(this.lblNomEst);
            this.Controls.Add(this.lblEstadioNombreClub);
            this.Controls.Add(this.lblEstadioNomClu);
            this.Controls.Add(this.btnEstadioAmpliar);
            this.Controls.Add(this.ptbEstadioCancha);
            this.Controls.Add(this.ptbFondoEstadio);
            this.Name = "Estadio";
            this.Text = "Estadio";
            this.Load += new System.EventHandler(this.Estadio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFondoEstadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEstadioCancha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFondoEstadio;
        private System.Windows.Forms.PictureBox ptbEstadioCancha;
        private System.Windows.Forms.Button btnEstadioAmpliar;
        private System.Windows.Forms.Label lblEspectadores;
        private System.Windows.Forms.Label lblEstadioCapacidad;
        private System.Windows.Forms.Label lblEstCap;
        private System.Windows.Forms.Label lblNombreEstadio;
        private System.Windows.Forms.Label lblNomEst;
        private System.Windows.Forms.Label lblEstadioNombreClub;
        private System.Windows.Forms.Label lblEstadioNomClu;
    }
}