namespace Football_Manager_2016
{
    partial class Configurar_Juego_Fixture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurar_Juego_Fixture));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxCfgSeleccionEquipoLocal = new System.Windows.Forms.ComboBox();
            this.lblCfgFechaPartido = new System.Windows.Forms.Label();
            this.dtpCfgFechaPartido = new System.Windows.Forms.DateTimePicker();
            this.lblCfgSeleccionEquipoLocal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCfgEstadio = new System.Windows.Forms.TextBox();
            this.btnCfgCargarPartido = new System.Windows.Forms.Button();
            this.lblCfgSeleccionEquipoVisitante = new System.Windows.Forms.Label();
            this.cbxCfgSeleccionEquipoVisitante = new System.Windows.Forms.ComboBox();
            this.lblCfgJornada = new System.Windows.Forms.Label();
            this.cbxCfgJornada = new System.Windows.Forms.ComboBox();
            this.GrillaPartidos = new System.Windows.Forms.DataGridView();
            this.ptbSeparador = new System.Windows.Forms.PictureBox();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.cbxCfgCompetencia = new System.Windows.Forms.ComboBox();
            this.Fec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarGrilla = new System.Windows.Forms.Button();
            this.btnEliminarPartido = new System.Windows.Forms.Button();
            this.btnEditarPartido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPartidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSeparador)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbxCfgSeleccionEquipoLocal
            // 
            this.cbxCfgSeleccionEquipoLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCfgSeleccionEquipoLocal.FormattingEnabled = true;
            this.cbxCfgSeleccionEquipoLocal.Items.AddRange(new object[] {
            "Aldosivi",
            "Arsenal",
            "Atlético Rafaela",
            "Atlético Tucumán",
            "Banfield",
            "Belgrano",
            "Boca Juniors",
            "Colón",
            "Defensa y Justicia",
            "Estudiantes (LP)",
            "Gimnasia (LP)",
            "Godoy Cruz",
            "Huracán",
            "Independiente",
            "Lanus",
            "Newell\'s",
            "Olimpo",
            "Patronato",
            "Quilmes",
            "Racing Club",
            "River Plate",
            "Rosario Central",
            "San Lorenzo",
            "San Martín (SJ)",
            "Sarmiento de Junín",
            "Talleres",
            "Temperley",
            "Tigre",
            "Unión",
            "Velez Sarfield"});
            this.cbxCfgSeleccionEquipoLocal.Location = new System.Drawing.Point(112, 79);
            this.cbxCfgSeleccionEquipoLocal.Name = "cbxCfgSeleccionEquipoLocal";
            this.cbxCfgSeleccionEquipoLocal.Size = new System.Drawing.Size(177, 21);
            this.cbxCfgSeleccionEquipoLocal.TabIndex = 1;
            this.cbxCfgSeleccionEquipoLocal.SelectedIndexChanged += new System.EventHandler(this.cbxCfgSeleccionEquipoLocal_SelectedIndexChanged);
            // 
            // lblCfgFechaPartido
            // 
            this.lblCfgFechaPartido.AutoSize = true;
            this.lblCfgFechaPartido.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCfgFechaPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgFechaPartido.Location = new System.Drawing.Point(27, 182);
            this.lblCfgFechaPartido.Name = "lblCfgFechaPartido";
            this.lblCfgFechaPartido.Size = new System.Drawing.Size(134, 16);
            this.lblCfgFechaPartido.TabIndex = 2;
            this.lblCfgFechaPartido.Text = "Fecha del partido:";
            // 
            // dtpCfgFechaPartido
            // 
            this.dtpCfgFechaPartido.Location = new System.Drawing.Point(168, 182);
            this.dtpCfgFechaPartido.Name = "dtpCfgFechaPartido";
            this.dtpCfgFechaPartido.Size = new System.Drawing.Size(200, 20);
            this.dtpCfgFechaPartido.TabIndex = 3;
            // 
            // lblCfgSeleccionEquipoLocal
            // 
            this.lblCfgSeleccionEquipoLocal.AutoSize = true;
            this.lblCfgSeleccionEquipoLocal.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCfgSeleccionEquipoLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgSeleccionEquipoLocal.Location = new System.Drawing.Point(113, 60);
            this.lblCfgSeleccionEquipoLocal.Name = "lblCfgSeleccionEquipoLocal";
            this.lblCfgSeleccionEquipoLocal.Size = new System.Drawing.Size(176, 16);
            this.lblCfgSeleccionEquipoLocal.TabIndex = 4;
            this.lblCfgSeleccionEquipoLocal.Text = "Seleccione equipo local\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Estadio:\r\n";
            // 
            // txtCfgEstadio
            // 
            this.txtCfgEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCfgEstadio.Location = new System.Drawing.Point(168, 233);
            this.txtCfgEstadio.Name = "txtCfgEstadio";
            this.txtCfgEstadio.ReadOnly = true;
            this.txtCfgEstadio.Size = new System.Drawing.Size(157, 20);
            this.txtCfgEstadio.TabIndex = 12;
            // 
            // btnCfgCargarPartido
            // 
            this.btnCfgCargarPartido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCfgCargarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCfgCargarPartido.ForeColor = System.Drawing.Color.White;
            this.btnCfgCargarPartido.Location = new System.Drawing.Point(112, 336);
            this.btnCfgCargarPartido.Name = "btnCfgCargarPartido";
            this.btnCfgCargarPartido.Size = new System.Drawing.Size(153, 43);
            this.btnCfgCargarPartido.TabIndex = 13;
            this.btnCfgCargarPartido.Text = "Cargar partido";
            this.btnCfgCargarPartido.UseVisualStyleBackColor = false;
            this.btnCfgCargarPartido.Click += new System.EventHandler(this.btnCfgCargarPartido_Click);
            // 
            // lblCfgSeleccionEquipoVisitante
            // 
            this.lblCfgSeleccionEquipoVisitante.AutoSize = true;
            this.lblCfgSeleccionEquipoVisitante.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCfgSeleccionEquipoVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgSeleccionEquipoVisitante.Location = new System.Drawing.Point(109, 114);
            this.lblCfgSeleccionEquipoVisitante.Name = "lblCfgSeleccionEquipoVisitante";
            this.lblCfgSeleccionEquipoVisitante.Size = new System.Drawing.Size(200, 16);
            this.lblCfgSeleccionEquipoVisitante.TabIndex = 15;
            this.lblCfgSeleccionEquipoVisitante.Text = "Seleccione equipo visitante";
            // 
            // cbxCfgSeleccionEquipoVisitante
            // 
            this.cbxCfgSeleccionEquipoVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCfgSeleccionEquipoVisitante.FormattingEnabled = true;
            this.cbxCfgSeleccionEquipoVisitante.Items.AddRange(new object[] {
            "Aldosivi",
            "Arsenal",
            "Atlético Rafaela",
            "Atlético Tucumán",
            "Banfield",
            "Belgrano",
            "Boca Juniors",
            "Colón",
            "Defensa y Justicia",
            "Estudiantes (LP)",
            "Gimnasia (LP)",
            "Godoy Cruz",
            "Huracán",
            "Independiente",
            "Lanus",
            "Newell\'s",
            "Olimpo",
            "Patronato",
            "Quilmes",
            "Racing Club",
            "River Plate",
            "Rosario Central",
            "San Lorenzo",
            "San Martín (SJ)",
            "Sarmiento de Junín",
            "Talleres",
            "Temperley",
            "Tigre",
            "Unión",
            "Velez Sarfield"});
            this.cbxCfgSeleccionEquipoVisitante.Location = new System.Drawing.Point(112, 133);
            this.cbxCfgSeleccionEquipoVisitante.Name = "cbxCfgSeleccionEquipoVisitante";
            this.cbxCfgSeleccionEquipoVisitante.Size = new System.Drawing.Size(177, 21);
            this.cbxCfgSeleccionEquipoVisitante.TabIndex = 14;
            // 
            // lblCfgJornada
            // 
            this.lblCfgJornada.AutoSize = true;
            this.lblCfgJornada.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCfgJornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgJornada.Location = new System.Drawing.Point(96, 285);
            this.lblCfgJornada.Name = "lblCfgJornada";
            this.lblCfgJornada.Size = new System.Drawing.Size(69, 16);
            this.lblCfgJornada.TabIndex = 16;
            this.lblCfgJornada.Text = "Jornada:";
            // 
            // cbxCfgJornada
            // 
            this.cbxCfgJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCfgJornada.FormattingEnabled = true;
            this.cbxCfgJornada.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cbxCfgJornada.Location = new System.Drawing.Point(171, 284);
            this.cbxCfgJornada.Name = "cbxCfgJornada";
            this.cbxCfgJornada.Size = new System.Drawing.Size(44, 21);
            this.cbxCfgJornada.TabIndex = 17;
            // 
            // GrillaPartidos
            // 
            this.GrillaPartidos.AllowUserToAddRows = false;
            this.GrillaPartidos.AllowUserToDeleteRows = false;
            this.GrillaPartidos.AllowUserToResizeColumns = false;
            this.GrillaPartidos.AllowUserToResizeRows = false;
            this.GrillaPartidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GrillaPartidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrillaPartidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPartidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fec,
            this.Compet,
            this.Loc,
            this.Vis,
            this.Est,
            this.Jor});
            this.GrillaPartidos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaPartidos.DefaultCellStyle = dataGridViewCellStyle4;
            this.GrillaPartidos.Location = new System.Drawing.Point(416, 0);
            this.GrillaPartidos.MultiSelect = false;
            this.GrillaPartidos.Name = "GrillaPartidos";
            this.GrillaPartidos.ReadOnly = true;
            this.GrillaPartidos.RowHeadersVisible = false;
            this.GrillaPartidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaPartidos.Size = new System.Drawing.Size(757, 341);
            this.GrillaPartidos.TabIndex = 46;
            // 
            // ptbSeparador
            // 
            this.ptbSeparador.BackColor = System.Drawing.Color.Gold;
            this.ptbSeparador.Location = new System.Drawing.Point(406, -2);
            this.ptbSeparador.Name = "ptbSeparador";
            this.ptbSeparador.Size = new System.Drawing.Size(10, 393);
            this.ptbSeparador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSeparador.TabIndex = 47;
            this.ptbSeparador.TabStop = false;
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblCompetencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetencia.Location = new System.Drawing.Point(59, 23);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(103, 16);
            this.lblCompetencia.TabIndex = 48;
            this.lblCompetencia.Text = "Competencia:";
            // 
            // cbxCfgCompetencia
            // 
            this.cbxCfgCompetencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCfgCompetencia.FormattingEnabled = true;
            this.cbxCfgCompetencia.Items.AddRange(new object[] {
            "Primera División",
            "B Nacional",
            "Copa Argentina",
            "Copa Libertadores",
            "Copa Sudamericana"});
            this.cbxCfgCompetencia.Location = new System.Drawing.Point(168, 22);
            this.cbxCfgCompetencia.Name = "cbxCfgCompetencia";
            this.cbxCfgCompetencia.Size = new System.Drawing.Size(138, 21);
            this.cbxCfgCompetencia.TabIndex = 49;
            // 
            // Fec
            // 
            this.Fec.Frozen = true;
            this.Fec.HeaderText = "Fecha";
            this.Fec.Name = "Fec";
            this.Fec.ReadOnly = true;
            // 
            // Compet
            // 
            this.Compet.Frozen = true;
            this.Compet.HeaderText = "Competencia";
            this.Compet.Name = "Compet";
            this.Compet.ReadOnly = true;
            this.Compet.Width = 150;
            // 
            // Loc
            // 
            this.Loc.Frozen = true;
            this.Loc.HeaderText = "Equipo Local";
            this.Loc.MinimumWidth = 45;
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            this.Loc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Loc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Loc.Width = 135;
            // 
            // Vis
            // 
            this.Vis.Frozen = true;
            this.Vis.HeaderText = "Equipo Visitante";
            this.Vis.MinimumWidth = 36;
            this.Vis.Name = "Vis";
            this.Vis.ReadOnly = true;
            this.Vis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Vis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Vis.Width = 170;
            // 
            // Est
            // 
            this.Est.Frozen = true;
            this.Est.HeaderText = "Estadio";
            this.Est.MinimumWidth = 109;
            this.Est.Name = "Est";
            this.Est.ReadOnly = true;
            this.Est.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Est.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Est.Width = 130;
            // 
            // Jor
            // 
            this.Jor.Frozen = true;
            this.Jor.HeaderText = "Jornada";
            this.Jor.MinimumWidth = 40;
            this.Jor.Name = "Jor";
            this.Jor.ReadOnly = true;
            this.Jor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Jor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Jor.Width = 50;
            // 
            // btnActualizarGrilla
            // 
            this.btnActualizarGrilla.BackColor = System.Drawing.Color.Black;
            this.btnActualizarGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarGrilla.Location = new System.Drawing.Point(722, 345);
            this.btnActualizarGrilla.Name = "btnActualizarGrilla";
            this.btnActualizarGrilla.Size = new System.Drawing.Size(166, 43);
            this.btnActualizarGrilla.TabIndex = 55;
            this.btnActualizarGrilla.Text = "Actualizar Tabla";
            this.btnActualizarGrilla.UseVisualStyleBackColor = false;
            this.btnActualizarGrilla.Click += new System.EventHandler(this.btnActualizarGrilla_Click);
            // 
            // btnEliminarPartido
            // 
            this.btnEliminarPartido.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPartido.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPartido.Location = new System.Drawing.Point(926, 345);
            this.btnEliminarPartido.Name = "btnEliminarPartido";
            this.btnEliminarPartido.Size = new System.Drawing.Size(166, 43);
            this.btnEliminarPartido.TabIndex = 54;
            this.btnEliminarPartido.Text = "Eliminar Partido";
            this.btnEliminarPartido.UseVisualStyleBackColor = false;
            this.btnEliminarPartido.Click += new System.EventHandler(this.btnEliminarPartido_Click);
            // 
            // btnEditarPartido
            // 
            this.btnEditarPartido.BackColor = System.Drawing.Color.Teal;
            this.btnEditarPartido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPartido.ForeColor = System.Drawing.Color.White;
            this.btnEditarPartido.Location = new System.Drawing.Point(507, 345);
            this.btnEditarPartido.Name = "btnEditarPartido";
            this.btnEditarPartido.Size = new System.Drawing.Size(166, 43);
            this.btnEditarPartido.TabIndex = 53;
            this.btnEditarPartido.Text = "Editar Partido";
            this.btnEditarPartido.UseVisualStyleBackColor = false;
            this.btnEditarPartido.Click += new System.EventHandler(this.btnEditarPartido_Click);
            // 
            // Configurar_Juego_Fixture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1169, 391);
            this.Controls.Add(this.btnActualizarGrilla);
            this.Controls.Add(this.btnEliminarPartido);
            this.Controls.Add(this.btnEditarPartido);
            this.Controls.Add(this.cbxCfgCompetencia);
            this.Controls.Add(this.lblCompetencia);
            this.Controls.Add(this.ptbSeparador);
            this.Controls.Add(this.GrillaPartidos);
            this.Controls.Add(this.cbxCfgJornada);
            this.Controls.Add(this.lblCfgJornada);
            this.Controls.Add(this.lblCfgSeleccionEquipoVisitante);
            this.Controls.Add(this.cbxCfgSeleccionEquipoVisitante);
            this.Controls.Add(this.btnCfgCargarPartido);
            this.Controls.Add(this.txtCfgEstadio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCfgSeleccionEquipoLocal);
            this.Controls.Add(this.dtpCfgFechaPartido);
            this.Controls.Add(this.lblCfgFechaPartido);
            this.Controls.Add(this.cbxCfgSeleccionEquipoLocal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Configurar_Juego_Fixture";
            this.Text = "Configurar_Juego_Fixture";
            this.Load += new System.EventHandler(this.Configurar_Juego_Fixture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPartidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSeparador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxCfgSeleccionEquipoLocal;
        private System.Windows.Forms.Label lblCfgFechaPartido;
        private System.Windows.Forms.DateTimePicker dtpCfgFechaPartido;
        private System.Windows.Forms.Label lblCfgSeleccionEquipoLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCfgEstadio;
        private System.Windows.Forms.Button btnCfgCargarPartido;
        private System.Windows.Forms.Label lblCfgSeleccionEquipoVisitante;
        private System.Windows.Forms.ComboBox cbxCfgSeleccionEquipoVisitante;
        private System.Windows.Forms.Label lblCfgJornada;
        private System.Windows.Forms.ComboBox cbxCfgJornada;
        private System.Windows.Forms.DataGridView GrillaPartidos;
        private System.Windows.Forms.PictureBox ptbSeparador;
        private System.Windows.Forms.Label lblCompetencia;
        private System.Windows.Forms.ComboBox cbxCfgCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jor;
        private System.Windows.Forms.Button btnActualizarGrilla;
        private System.Windows.Forms.Button btnEliminarPartido;
        private System.Windows.Forms.Button btnEditarPartido;
    }
}