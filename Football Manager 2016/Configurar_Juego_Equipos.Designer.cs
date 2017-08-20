namespace Football_Manager_2016
{
    partial class Configurar_Juego_Equipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurar_Juego_Equipos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbxCfgSeleccionEquipo = new System.Windows.Forms.ComboBox();
            this.cbxCfgDivisionEquipo = new System.Windows.Forms.ComboBox();
            this.lblCfgNombreEquipo = new System.Windows.Forms.Label();
            this.lblCfgDivisionEquipo = new System.Windows.Forms.Label();
            this.lblCfgNombreEstadio = new System.Windows.Forms.Label();
            this.txtCfgNombreEstadio = new System.Windows.Forms.TextBox();
            this.lblCfgCapacidadEstadio = new System.Windows.Forms.Label();
            this.lblCfgPresupuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCfgCargarEquipo = new System.Windows.Forms.Button();
            this.GrillaEquipos = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Div = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptbSeparador = new System.Windows.Forms.PictureBox();
            this.ntxtCfgCapacidadEstadio = new Aga.Controls.NumericTextBox();
            this.ntxtCfgPresupuesto = new Aga.Controls.NumericTextBox();
            this.btnEditarEquipo = new System.Windows.Forms.Button();
            this.btnEliminarEquipo = new System.Windows.Forms.Button();
            this.btnActualizarGrilla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSeparador)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbxCfgSeleccionEquipo
            // 
            this.cbxCfgSeleccionEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCfgSeleccionEquipo.FormattingEnabled = true;
            this.cbxCfgSeleccionEquipo.Items.AddRange(new object[] {
            "Argentinos Juniors",
            "Arsenal",
            "Atlético Tucumán",
            "Banfield",
            "Belgrano",
            "Boca Juniors",
            "Chacarita Juniors",
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
            "Racing Club",
            "River Plate",
            "Rosario Central",
            "San Lorenzo",
            "San Martín (SJ)",
            "Talleres",
            "Temperley",
            "Tigre",
            "Unión",
            "Velez Sarfield",
            "Agropecuario",
            "Aldosivi",
            "All Boys",
            "Almagro",
            "Atlético Rafaela",
            "Boca Unidos",
            "Brown de Adrogué",
            "Deportivo Morón",
            "Deportivo Riestra",
            "Ferro Carril Oeste",
            "Flandria",
            "Gimnasia de Jujuy",
            "Guillermo Brown",
            "Independiente Rivadavia",
            "Instituto",
            "Juventud Unida",
            "Los Andes",
            "Mitre",
            "Nueva Chicago",
            "Quilmes",
            "Santamarina de Tandil",
            "San Martín de Tucumán",
            "Sarmiento de Junín",
            "Estudiantes (SL)",
            "Villa Dálmine"});
            this.cbxCfgSeleccionEquipo.Location = new System.Drawing.Point(268, 40);
            this.cbxCfgSeleccionEquipo.Name = "cbxCfgSeleccionEquipo";
            this.cbxCfgSeleccionEquipo.Size = new System.Drawing.Size(199, 21);
            this.cbxCfgSeleccionEquipo.TabIndex = 1;
            // 
            // cbxCfgDivisionEquipo
            // 
            this.cbxCfgDivisionEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCfgDivisionEquipo.FormattingEnabled = true;
            this.cbxCfgDivisionEquipo.Items.AddRange(new object[] {
            "Primera División",
            "B Nacional",
            "Libertadores",
            "Sudamericana"});
            this.cbxCfgDivisionEquipo.Location = new System.Drawing.Point(268, 94);
            this.cbxCfgDivisionEquipo.Name = "cbxCfgDivisionEquipo";
            this.cbxCfgDivisionEquipo.Size = new System.Drawing.Size(121, 21);
            this.cbxCfgDivisionEquipo.TabIndex = 2;
            // 
            // lblCfgNombreEquipo
            // 
            this.lblCfgNombreEquipo.AutoSize = true;
            this.lblCfgNombreEquipo.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblCfgNombreEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgNombreEquipo.ForeColor = System.Drawing.Color.White;
            this.lblCfgNombreEquipo.Location = new System.Drawing.Point(142, 40);
            this.lblCfgNombreEquipo.Name = "lblCfgNombreEquipo";
            this.lblCfgNombreEquipo.Size = new System.Drawing.Size(83, 24);
            this.lblCfgNombreEquipo.TabIndex = 3;
            this.lblCfgNombreEquipo.Text = "Equipo:";
            // 
            // lblCfgDivisionEquipo
            // 
            this.lblCfgDivisionEquipo.AutoSize = true;
            this.lblCfgDivisionEquipo.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblCfgDivisionEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgDivisionEquipo.ForeColor = System.Drawing.Color.White;
            this.lblCfgDivisionEquipo.Location = new System.Drawing.Point(135, 91);
            this.lblCfgDivisionEquipo.Name = "lblCfgDivisionEquipo";
            this.lblCfgDivisionEquipo.Size = new System.Drawing.Size(89, 24);
            this.lblCfgDivisionEquipo.TabIndex = 4;
            this.lblCfgDivisionEquipo.Text = "División:";
            // 
            // lblCfgNombreEstadio
            // 
            this.lblCfgNombreEstadio.AutoSize = true;
            this.lblCfgNombreEstadio.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblCfgNombreEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgNombreEstadio.ForeColor = System.Drawing.Color.White;
            this.lblCfgNombreEstadio.Location = new System.Drawing.Point(58, 144);
            this.lblCfgNombreEstadio.Name = "lblCfgNombreEstadio";
            this.lblCfgNombreEstadio.Size = new System.Drawing.Size(166, 24);
            this.lblCfgNombreEstadio.TabIndex = 5;
            this.lblCfgNombreEstadio.Text = "Nombre Estadio:";
            // 
            // txtCfgNombreEstadio
            // 
            this.txtCfgNombreEstadio.Location = new System.Drawing.Point(268, 148);
            this.txtCfgNombreEstadio.Name = "txtCfgNombreEstadio";
            this.txtCfgNombreEstadio.Size = new System.Drawing.Size(199, 20);
            this.txtCfgNombreEstadio.TabIndex = 6;
            // 
            // lblCfgCapacidadEstadio
            // 
            this.lblCfgCapacidadEstadio.AutoSize = true;
            this.lblCfgCapacidadEstadio.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblCfgCapacidadEstadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgCapacidadEstadio.ForeColor = System.Drawing.Color.White;
            this.lblCfgCapacidadEstadio.Location = new System.Drawing.Point(35, 204);
            this.lblCfgCapacidadEstadio.Name = "lblCfgCapacidadEstadio";
            this.lblCfgCapacidadEstadio.Size = new System.Drawing.Size(190, 24);
            this.lblCfgCapacidadEstadio.TabIndex = 7;
            this.lblCfgCapacidadEstadio.Text = "Capacidad Estadio:";
            // 
            // lblCfgPresupuesto
            // 
            this.lblCfgPresupuesto.AutoSize = true;
            this.lblCfgPresupuesto.BackColor = System.Drawing.Color.SaddleBrown;
            this.lblCfgPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfgPresupuesto.ForeColor = System.Drawing.Color.White;
            this.lblCfgPresupuesto.Location = new System.Drawing.Point(11, 270);
            this.lblCfgPresupuesto.Name = "lblCfgPresupuesto";
            this.lblCfgPresupuesto.Size = new System.Drawing.Size(214, 24);
            this.lblCfgPresupuesto.TabIndex = 9;
            this.lblCfgPresupuesto.Text = "Presupuesto del club:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(241, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "$\r\n";
            // 
            // btnCfgCargarEquipo
            // 
            this.btnCfgCargarEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCfgCargarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCfgCargarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnCfgCargarEquipo.Location = new System.Drawing.Point(158, 357);
            this.btnCfgCargarEquipo.Name = "btnCfgCargarEquipo";
            this.btnCfgCargarEquipo.Size = new System.Drawing.Size(153, 43);
            this.btnCfgCargarEquipo.TabIndex = 12;
            this.btnCfgCargarEquipo.Text = "Cargar Equipo";
            this.btnCfgCargarEquipo.UseVisualStyleBackColor = false;
            this.btnCfgCargarEquipo.Click += new System.EventHandler(this.btnCfgCargarEquipo_Click);
            // 
            // GrillaEquipos
            // 
            this.GrillaEquipos.AllowUserToAddRows = false;
            this.GrillaEquipos.AllowUserToDeleteRows = false;
            this.GrillaEquipos.AllowUserToResizeColumns = false;
            this.GrillaEquipos.AllowUserToResizeRows = false;
            this.GrillaEquipos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GrillaEquipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrillaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Div,
            this.NomEst,
            this.CapEst,
            this.PreClub});
            this.GrillaEquipos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaEquipos.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaEquipos.Location = new System.Drawing.Point(530, 0);
            this.GrillaEquipos.MultiSelect = false;
            this.GrillaEquipos.Name = "GrillaEquipos";
            this.GrillaEquipos.ReadOnly = true;
            this.GrillaEquipos.RowHeadersVisible = false;
            this.GrillaEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaEquipos.Size = new System.Drawing.Size(691, 400);
            this.GrillaEquipos.TabIndex = 45;
            // 
            // Nom
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nom.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nom.Frozen = true;
            this.Nom.HeaderText = "Nombre";
            this.Nom.MinimumWidth = 133;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nom.Width = 150;
            // 
            // Div
            // 
            this.Div.Frozen = true;
            this.Div.HeaderText = "División";
            this.Div.MinimumWidth = 45;
            this.Div.Name = "Div";
            this.Div.ReadOnly = true;
            this.Div.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Div.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Div.Width = 135;
            // 
            // NomEst
            // 
            this.NomEst.Frozen = true;
            this.NomEst.HeaderText = "Nombre Estadio";
            this.NomEst.MinimumWidth = 36;
            this.NomEst.Name = "NomEst";
            this.NomEst.ReadOnly = true;
            this.NomEst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomEst.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NomEst.Width = 170;
            // 
            // CapEst
            // 
            this.CapEst.Frozen = true;
            this.CapEst.HeaderText = "Capacidad Estadio";
            this.CapEst.MinimumWidth = 109;
            this.CapEst.Name = "CapEst";
            this.CapEst.ReadOnly = true;
            this.CapEst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CapEst.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CapEst.Width = 130;
            // 
            // PreClub
            // 
            this.PreClub.Frozen = true;
            this.PreClub.HeaderText = "Presupuesto Club";
            this.PreClub.MinimumWidth = 106;
            this.PreClub.Name = "PreClub";
            this.PreClub.ReadOnly = true;
            this.PreClub.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PreClub.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PreClub.Width = 106;
            // 
            // ptbSeparador
            // 
            this.ptbSeparador.BackColor = System.Drawing.Color.Gold;
            this.ptbSeparador.Location = new System.Drawing.Point(523, 0);
            this.ptbSeparador.Name = "ptbSeparador";
            this.ptbSeparador.Size = new System.Drawing.Size(10, 450);
            this.ptbSeparador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSeparador.TabIndex = 46;
            this.ptbSeparador.TabStop = false;
            // 
            // ntxtCfgCapacidadEstadio
            // 
            this.ntxtCfgCapacidadEstadio.AllowDecimalSeparator = false;
            this.ntxtCfgCapacidadEstadio.AllowNegativeSign = false;
            this.ntxtCfgCapacidadEstadio.Location = new System.Drawing.Point(268, 207);
            this.ntxtCfgCapacidadEstadio.Name = "ntxtCfgCapacidadEstadio";
            this.ntxtCfgCapacidadEstadio.Size = new System.Drawing.Size(199, 20);
            this.ntxtCfgCapacidadEstadio.TabIndex = 47;
            // 
            // ntxtCfgPresupuesto
            // 
            this.ntxtCfgPresupuesto.AllowDecimalSeparator = false;
            this.ntxtCfgPresupuesto.AllowNegativeSign = false;
            this.ntxtCfgPresupuesto.Location = new System.Drawing.Point(268, 273);
            this.ntxtCfgPresupuesto.Name = "ntxtCfgPresupuesto";
            this.ntxtCfgPresupuesto.Size = new System.Drawing.Size(199, 20);
            this.ntxtCfgPresupuesto.TabIndex = 48;
            // 
            // btnEditarEquipo
            // 
            this.btnEditarEquipo.BackColor = System.Drawing.Color.Teal;
            this.btnEditarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnEditarEquipo.Location = new System.Drawing.Point(610, 404);
            this.btnEditarEquipo.Name = "btnEditarEquipo";
            this.btnEditarEquipo.Size = new System.Drawing.Size(166, 43);
            this.btnEditarEquipo.TabIndex = 49;
            this.btnEditarEquipo.Text = "Editar Equipo";
            this.btnEditarEquipo.UseVisualStyleBackColor = false;
            this.btnEditarEquipo.Click += new System.EventHandler(this.btnEditarEquipo_Click);
            // 
            // btnEliminarEquipo
            // 
            this.btnEliminarEquipo.BackColor = System.Drawing.Color.Red;
            this.btnEliminarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEquipo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEquipo.Location = new System.Drawing.Point(1029, 404);
            this.btnEliminarEquipo.Name = "btnEliminarEquipo";
            this.btnEliminarEquipo.Size = new System.Drawing.Size(166, 43);
            this.btnEliminarEquipo.TabIndex = 51;
            this.btnEliminarEquipo.Text = "Eliminar Equipo";
            this.btnEliminarEquipo.UseVisualStyleBackColor = false;
            this.btnEliminarEquipo.Click += new System.EventHandler(this.btnEliminarEquipo_Click);
            // 
            // btnActualizarGrilla
            // 
            this.btnActualizarGrilla.BackColor = System.Drawing.Color.Black;
            this.btnActualizarGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarGrilla.Location = new System.Drawing.Point(825, 404);
            this.btnActualizarGrilla.Name = "btnActualizarGrilla";
            this.btnActualizarGrilla.Size = new System.Drawing.Size(166, 43);
            this.btnActualizarGrilla.TabIndex = 52;
            this.btnActualizarGrilla.Text = "Actualizar Tabla";
            this.btnActualizarGrilla.UseVisualStyleBackColor = false;
            this.btnActualizarGrilla.Click += new System.EventHandler(this.btnActualizarGrilla_Click);
            // 
            // Configurar_Juego_Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1241, 449);
            this.Controls.Add(this.btnActualizarGrilla);
            this.Controls.Add(this.btnEliminarEquipo);
            this.Controls.Add(this.btnEditarEquipo);
            this.Controls.Add(this.ntxtCfgPresupuesto);
            this.Controls.Add(this.ntxtCfgCapacidadEstadio);
            this.Controls.Add(this.ptbSeparador);
            this.Controls.Add(this.GrillaEquipos);
            this.Controls.Add(this.btnCfgCargarEquipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCfgPresupuesto);
            this.Controls.Add(this.lblCfgCapacidadEstadio);
            this.Controls.Add(this.txtCfgNombreEstadio);
            this.Controls.Add(this.lblCfgNombreEstadio);
            this.Controls.Add(this.lblCfgDivisionEquipo);
            this.Controls.Add(this.lblCfgNombreEquipo);
            this.Controls.Add(this.cbxCfgDivisionEquipo);
            this.Controls.Add(this.cbxCfgSeleccionEquipo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1257, 488);
            this.MinimumSize = new System.Drawing.Size(1257, 488);
            this.Name = "Configurar_Juego_Equipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar_Juego_Equipos";
            this.Load += new System.EventHandler(this.Configurar_Juego_Equipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSeparador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbxCfgSeleccionEquipo;
        private System.Windows.Forms.ComboBox cbxCfgDivisionEquipo;
        private System.Windows.Forms.Label lblCfgNombreEquipo;
        private System.Windows.Forms.Label lblCfgDivisionEquipo;
        private System.Windows.Forms.Label lblCfgNombreEstadio;
        private System.Windows.Forms.TextBox txtCfgNombreEstadio;
        private System.Windows.Forms.Label lblCfgCapacidadEstadio;
        private System.Windows.Forms.Label lblCfgPresupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCfgCargarEquipo;
        private System.Windows.Forms.DataGridView GrillaEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Div;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreClub;
        private System.Windows.Forms.PictureBox ptbSeparador;
        private Aga.Controls.NumericTextBox ntxtCfgCapacidadEstadio;
        private Aga.Controls.NumericTextBox ntxtCfgPresupuesto;
        private System.Windows.Forms.Button btnEditarEquipo;
        private System.Windows.Forms.Button btnEliminarEquipo;
        private System.Windows.Forms.Button btnActualizarGrilla;
    }
}