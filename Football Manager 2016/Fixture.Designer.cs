namespace Football_Manager_2016
{
    partial class Fixture
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
            this.ptbFondoFixture = new System.Windows.Forms.PictureBox();
            this.lblEquipoFixture = new System.Windows.Forms.Label();
            this.ptbEscudoFixture = new System.Windows.Forms.PictureBox();
            this.lblFixture = new System.Windows.Forms.Label();
            this.listViewFixture = new System.Windows.Forms.ListView();
            this.FechaPartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Resultado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipoLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GolesLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GolesVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipoVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estadio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GananciaEntradas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Espectadores = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jornada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerFixtureCompleto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFondoFixture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEscudoFixture)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbFondoFixture
            // 
            this.ptbFondoFixture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbFondoFixture.Location = new System.Drawing.Point(0, 0);
            this.ptbFondoFixture.Name = "ptbFondoFixture";
            this.ptbFondoFixture.Size = new System.Drawing.Size(1039, 540);
            this.ptbFondoFixture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFondoFixture.TabIndex = 0;
            this.ptbFondoFixture.TabStop = false;
            // 
            // lblEquipoFixture
            // 
            this.lblEquipoFixture.AutoSize = true;
            this.lblEquipoFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipoFixture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEquipoFixture.Location = new System.Drawing.Point(212, 23);
            this.lblEquipoFixture.Name = "lblEquipoFixture";
            this.lblEquipoFixture.Size = new System.Drawing.Size(213, 29);
            this.lblEquipoFixture.TabIndex = 7;
            this.lblEquipoFixture.Text = "(Nombre equipo)";
            // 
            // ptbEscudoFixture
            // 
            this.ptbEscudoFixture.Location = new System.Drawing.Point(23, 8);
            this.ptbEscudoFixture.Name = "ptbEscudoFixture";
            this.ptbEscudoFixture.Size = new System.Drawing.Size(60, 60);
            this.ptbEscudoFixture.TabIndex = 6;
            this.ptbEscudoFixture.TabStop = false;
            // 
            // lblFixture
            // 
            this.lblFixture.AutoSize = true;
            this.lblFixture.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFixture.Location = new System.Drawing.Point(103, 23);
            this.lblFixture.Name = "lblFixture";
            this.lblFixture.Size = new System.Drawing.Size(93, 29);
            this.lblFixture.TabIndex = 5;
            this.lblFixture.Text = "Fixture";
            // 
            // listViewFixture
            // 
            this.listViewFixture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FechaPartido,
            this.Resultado,
            this.EquipoLocal,
            this.GolesLocal,
            this.x,
            this.GolesVisitante,
            this.EquipoVisitante,
            this.Estadio,
            this.GananciaEntradas,
            this.Espectadores,
            this.Jornada});
            this.listViewFixture.Location = new System.Drawing.Point(12, 74);
            this.listViewFixture.Name = "listViewFixture";
            this.listViewFixture.Size = new System.Drawing.Size(1013, 452);
            this.listViewFixture.TabIndex = 4;
            this.listViewFixture.UseCompatibleStateImageBehavior = false;
            this.listViewFixture.View = System.Windows.Forms.View.Details;
            // 
            // FechaPartido
            // 
            this.FechaPartido.Text = "Fecha del partido";
            this.FechaPartido.Width = 94;
            // 
            // Resultado
            // 
            this.Resultado.Text = "Resultado";
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Resultado.Width = 68;
            // 
            // EquipoLocal
            // 
            this.EquipoLocal.Text = "Equipo local";
            this.EquipoLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipoLocal.Width = 121;
            // 
            // GolesLocal
            // 
            this.GolesLocal.Text = "GL";
            this.GolesLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GolesLocal.Width = 30;
            // 
            // x
            // 
            this.x.Text = "";
            this.x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.x.Width = 18;
            // 
            // GolesVisitante
            // 
            this.GolesVisitante.Text = "GV";
            this.GolesVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GolesVisitante.Width = 30;
            // 
            // EquipoVisitante
            // 
            this.EquipoVisitante.Text = "Equipo visitante";
            this.EquipoVisitante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EquipoVisitante.Width = 121;
            // 
            // Estadio
            // 
            this.Estadio.Text = "Estadio";
            this.Estadio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Estadio.Width = 185;
            // 
            // GananciaEntradas
            // 
            this.GananciaEntradas.Text = "Ganancia entradas";
            this.GananciaEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GananciaEntradas.Width = 132;
            // 
            // Espectadores
            // 
            this.Espectadores.Text = "Espectadores";
            this.Espectadores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Espectadores.Width = 78;
            // 
            // Jornada
            // 
            this.Jornada.Text = "Jornada";
            // 
            // btnVerFixtureCompleto
            // 
            this.btnVerFixtureCompleto.BackColor = System.Drawing.Color.Black;
            this.btnVerFixtureCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFixtureCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerFixtureCompleto.Location = new System.Drawing.Point(733, 20);
            this.btnVerFixtureCompleto.Name = "btnVerFixtureCompleto";
            this.btnVerFixtureCompleto.Size = new System.Drawing.Size(246, 39);
            this.btnVerFixtureCompleto.TabIndex = 8;
            this.btnVerFixtureCompleto.Text = "Ver fixture completo";
            this.btnVerFixtureCompleto.UseVisualStyleBackColor = false;
            this.btnVerFixtureCompleto.Click += new System.EventHandler(this.btnVerFixtureCompleto_Click);
            // 
            // Fixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 537);
            this.Controls.Add(this.btnVerFixtureCompleto);
            this.Controls.Add(this.lblEquipoFixture);
            this.Controls.Add(this.ptbEscudoFixture);
            this.Controls.Add(this.lblFixture);
            this.Controls.Add(this.listViewFixture);
            this.Controls.Add(this.ptbFondoFixture);
            this.Name = "Fixture";
            this.Text = "Fixture";
            this.Load += new System.EventHandler(this.Fixture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFondoFixture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEscudoFixture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbFondoFixture;
        private System.Windows.Forms.Label lblEquipoFixture;
        private System.Windows.Forms.PictureBox ptbEscudoFixture;
        private System.Windows.Forms.Label lblFixture;
        private System.Windows.Forms.ListView listViewFixture;
        private System.Windows.Forms.ColumnHeader FechaPartido;
        private System.Windows.Forms.ColumnHeader Resultado;
        private System.Windows.Forms.ColumnHeader EquipoLocal;
        private System.Windows.Forms.ColumnHeader GolesLocal;
        private System.Windows.Forms.ColumnHeader x;
        private System.Windows.Forms.ColumnHeader GolesVisitante;
        private System.Windows.Forms.ColumnHeader EquipoVisitante;
        private System.Windows.Forms.ColumnHeader Estadio;
        private System.Windows.Forms.ColumnHeader GananciaEntradas;
        private System.Windows.Forms.ColumnHeader Espectadores;
        private System.Windows.Forms.ColumnHeader Jornada;
        private System.Windows.Forms.Button btnVerFixtureCompleto;

    }
}