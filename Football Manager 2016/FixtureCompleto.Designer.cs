namespace Football_Manager_2016
{
    partial class FixtureCompleto
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
            this.lblFixtureCompleto = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewFixture = new System.Windows.Forms.ListView();
            this.FechaPartido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Resultado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipoLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GolesLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GolesVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EquipoVisitante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Estadio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jornada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechaAtras = new System.Windows.Forms.Button();
            this.txtFechaActual = new System.Windows.Forms.TextBox();
            this.btnFechaAdelante = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFixtureCompleto
            // 
            this.lblFixtureCompleto.AutoSize = true;
            this.lblFixtureCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixtureCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFixtureCompleto.Location = new System.Drawing.Point(287, 19);
            this.lblFixtureCompleto.Name = "lblFixtureCompleto";
            this.lblFixtureCompleto.Size = new System.Drawing.Size(323, 29);
            this.lblFixtureCompleto.TabIndex = 6;
            this.lblFixtureCompleto.Text = "Fixture completo de la liga";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 480);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewFixture);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Torneo Local";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.Jornada});
            this.listViewFixture.Location = new System.Drawing.Point(0, 0);
            this.listViewFixture.Name = "listViewFixture";
            this.listViewFixture.Size = new System.Drawing.Size(891, 452);
            this.listViewFixture.TabIndex = 6;
            this.listViewFixture.UseCompatibleStateImageBehavior = false;
            this.listViewFixture.View = System.Windows.Forms.View.Details;
            this.listViewFixture.SelectedIndexChanged += new System.EventHandler(this.listViewFixture_SelectedIndexChanged);
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
            this.Resultado.Width = 175;
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
            this.Estadio.Width = 210;
            // 
            // Jornada
            // 
            this.Jornada.Text = "Jornada";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Copa Argentina";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha :";
            // 
            // btnFechaAtras
            // 
            this.btnFechaAtras.Location = new System.Drawing.Point(117, 546);
            this.btnFechaAtras.Name = "btnFechaAtras";
            this.btnFechaAtras.Size = new System.Drawing.Size(53, 31);
            this.btnFechaAtras.TabIndex = 9;
            this.btnFechaAtras.UseVisualStyleBackColor = true;
            this.btnFechaAtras.Click += new System.EventHandler(this.btnFechaAtras_Click);
            // 
            // txtFechaActual
            // 
            this.txtFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaActual.Location = new System.Drawing.Point(176, 547);
            this.txtFechaActual.Multiline = true;
            this.txtFechaActual.Name = "txtFechaActual";
            this.txtFechaActual.ReadOnly = true;
            this.txtFechaActual.Size = new System.Drawing.Size(37, 29);
            this.txtFechaActual.TabIndex = 10;
            this.txtFechaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaActual.TextChanged += new System.EventHandler(this.txtFechaActual_TextChanged);
            // 
            // btnFechaAdelante
            // 
            this.btnFechaAdelante.Location = new System.Drawing.Point(219, 546);
            this.btnFechaAdelante.Name = "btnFechaAdelante";
            this.btnFechaAdelante.Size = new System.Drawing.Size(53, 31);
            this.btnFechaAdelante.TabIndex = 11;
            this.btnFechaAdelante.UseVisualStyleBackColor = true;
            this.btnFechaAdelante.Click += new System.EventHandler(this.btnFechaAdelante_Click);
            // 
            // FixtureCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(925, 586);
            this.Controls.Add(this.btnFechaAdelante);
            this.Controls.Add(this.txtFechaActual);
            this.Controls.Add(this.btnFechaAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblFixtureCompleto);
            this.Name = "FixtureCompleto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FixtureCompleto";
            this.Load += new System.EventHandler(this.FixtureCompleto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFixtureCompleto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listViewFixture;
        private System.Windows.Forms.ColumnHeader FechaPartido;
        private System.Windows.Forms.ColumnHeader Resultado;
        private System.Windows.Forms.ColumnHeader EquipoLocal;
        private System.Windows.Forms.ColumnHeader GolesLocal;
        private System.Windows.Forms.ColumnHeader x;
        private System.Windows.Forms.ColumnHeader GolesVisitante;
        private System.Windows.Forms.ColumnHeader EquipoVisitante;
        private System.Windows.Forms.ColumnHeader Estadio;
        private System.Windows.Forms.ColumnHeader Jornada;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechaAtras;
        private System.Windows.Forms.TextBox txtFechaActual;
        private System.Windows.Forms.Button btnFechaAdelante;
    }
}