namespace Football_Manager_2016
{
    partial class Negociaciones
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
            this.GrillaJugadoresNegociaciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNegociaciones = new System.Windows.Forms.Label();
            this.btnBuscarNegociaciones = new System.Windows.Forms.Button();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.btnVaciarCampos = new System.Windows.Forms.Button();
            this.btnComprarJugador = new System.Windows.Forms.Button();
            this.btnHacerUnaOferta = new System.Windows.Forms.Button();
            this.gbxClub = new System.Windows.Forms.GroupBox();
            this.cbxClub = new System.Windows.Forms.ComboBox();
            this.gbxSalario = new System.Windows.Forms.GroupBox();
            this.ntxtSalMax = new Aga.Controls.NumericTextBox();
            this.ntxtSalMin = new Aga.Controls.NumericTextBox();
            this.lblMaxSalario = new System.Windows.Forms.Label();
            this.lblMinSalario = new System.Windows.Forms.Label();
            this.gbxValor = new System.Windows.Forms.GroupBox();
            this.ntxtValMax = new Aga.Controls.NumericTextBox();
            this.ntxtValMin = new Aga.Controls.NumericTextBox();
            this.lblValorMax = new System.Windows.Forms.Label();
            this.lblValorMin = new System.Windows.Forms.Label();
            this.gbxEdad = new System.Windows.Forms.GroupBox();
            this.gbxPosicion = new System.Windows.Forms.GroupBox();
            this.cbxPosicion = new System.Windows.Forms.ComboBox();
            this.gbxNombre = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbxFuerza = new System.Windows.Forms.GroupBox();
            this.ntxtFuerMax = new Aga.Controls.NumericTextBox();
            this.ntxtFuerMin = new Aga.Controls.NumericTextBox();
            this.lblFuerzaMax = new System.Windows.Forms.Label();
            this.lblFuerzaMin = new System.Windows.Forms.Label();
            this.cbxEdad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaJugadoresNegociaciones)).BeginInit();
            this.gbxClub.SuspendLayout();
            this.gbxSalario.SuspendLayout();
            this.gbxValor.SuspendLayout();
            this.gbxEdad.SuspendLayout();
            this.gbxPosicion.SuspendLayout();
            this.gbxNombre.SuspendLayout();
            this.gbxFuerza.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaJugadoresNegociaciones
            // 
            this.GrillaJugadoresNegociaciones.AllowUserToAddRows = false;
            this.GrillaJugadoresNegociaciones.AllowUserToDeleteRows = false;
            this.GrillaJugadoresNegociaciones.AllowUserToResizeColumns = false;
            this.GrillaJugadoresNegociaciones.AllowUserToResizeRows = false;
            this.GrillaJugadoresNegociaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GrillaJugadoresNegociaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaJugadoresNegociaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.GrillaJugadoresNegociaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GrillaJugadoresNegociaciones.Location = new System.Drawing.Point(497, 79);
            this.GrillaJugadoresNegociaciones.Name = "GrillaJugadoresNegociaciones";
            this.GrillaJugadoresNegociaciones.RowHeadersVisible = false;
            this.GrillaJugadoresNegociaciones.Size = new System.Drawing.Size(609, 467);
            this.GrillaJugadoresNegociaciones.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Fuerza";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Club";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Pos";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Salario";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Valor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Edad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 40;
            // 
            // lblNegociaciones
            // 
            this.lblNegociaciones.AutoSize = true;
            this.lblNegociaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNegociaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNegociaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNegociaciones.Location = new System.Drawing.Point(411, 21);
            this.lblNegociaciones.Name = "lblNegociaciones";
            this.lblNegociaciones.Size = new System.Drawing.Size(273, 33);
            this.lblNegociaciones.TabIndex = 1;
            this.lblNegociaciones.Text = "NEGOCIACIONES";
            // 
            // btnBuscarNegociaciones
            // 
            this.btnBuscarNegociaciones.BackColor = System.Drawing.Color.Black;
            this.btnBuscarNegociaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarNegociaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscarNegociaciones.Location = new System.Drawing.Point(216, 595);
            this.btnBuscarNegociaciones.Name = "btnBuscarNegociaciones";
            this.btnBuscarNegociaciones.Size = new System.Drawing.Size(172, 36);
            this.btnBuscarNegociaciones.TabIndex = 65;
            this.btnBuscarNegociaciones.Text = "Buscar";
            this.btnBuscarNegociaciones.UseVisualStyleBackColor = false;
            this.btnBuscarNegociaciones.Click += new System.EventHandler(this.btnBuscarNegociaciones_Click);
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFiltros.Location = new System.Drawing.Point(138, 53);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(135, 29);
            this.lblFiltros.TabIndex = 66;
            this.lblFiltros.Text = "Filtrar por:";
            // 
            // btnVaciarCampos
            // 
            this.btnVaciarCampos.BackColor = System.Drawing.Color.Black;
            this.btnVaciarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarCampos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaciarCampos.Location = new System.Drawing.Point(29, 595);
            this.btnVaciarCampos.Name = "btnVaciarCampos";
            this.btnVaciarCampos.Size = new System.Drawing.Size(170, 36);
            this.btnVaciarCampos.TabIndex = 74;
            this.btnVaciarCampos.Text = "Vaciar campos";
            this.btnVaciarCampos.UseVisualStyleBackColor = false;
            this.btnVaciarCampos.Click += new System.EventHandler(this.btnVaciarCampos_Click);
            // 
            // btnComprarJugador
            // 
            this.btnComprarJugador.BackColor = System.Drawing.Color.Black;
            this.btnComprarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarJugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComprarJugador.Location = new System.Drawing.Point(534, 566);
            this.btnComprarJugador.Name = "btnComprarJugador";
            this.btnComprarJugador.Size = new System.Drawing.Size(139, 36);
            this.btnComprarJugador.TabIndex = 75;
            this.btnComprarJugador.Text = "Comprar";
            this.btnComprarJugador.UseVisualStyleBackColor = false;
            // 
            // btnHacerUnaOferta
            // 
            this.btnHacerUnaOferta.BackColor = System.Drawing.Color.Black;
            this.btnHacerUnaOferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerUnaOferta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHacerUnaOferta.Location = new System.Drawing.Point(790, 566);
            this.btnHacerUnaOferta.Name = "btnHacerUnaOferta";
            this.btnHacerUnaOferta.Size = new System.Drawing.Size(185, 36);
            this.btnHacerUnaOferta.TabIndex = 76;
            this.btnHacerUnaOferta.Text = "Hacer una oferta";
            this.btnHacerUnaOferta.UseVisualStyleBackColor = false;
            // 
            // gbxClub
            // 
            this.gbxClub.Controls.Add(this.cbxClub);
            this.gbxClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbxClub.Location = new System.Drawing.Point(76, 105);
            this.gbxClub.Name = "gbxClub";
            this.gbxClub.Size = new System.Drawing.Size(298, 72);
            this.gbxClub.TabIndex = 73;
            this.gbxClub.TabStop = false;
            this.gbxClub.Text = "Club";
            // 
            // cbxClub
            // 
            this.cbxClub.DropDownWidth = 121;
            this.cbxClub.FormattingEnabled = true;
            this.cbxClub.IntegralHeight = false;
            this.cbxClub.ItemHeight = 24;
            this.cbxClub.Items.AddRange(new object[] {
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
            this.cbxClub.Location = new System.Drawing.Point(25, 28);
            this.cbxClub.Name = "cbxClub";
            this.cbxClub.Size = new System.Drawing.Size(247, 32);
            this.cbxClub.TabIndex = 0;
            this.cbxClub.SelectedIndexChanged += new System.EventHandler(this.cbxClub_SelectedIndexChanged);
            // 
            // gbxSalario
            // 
            this.gbxSalario.Controls.Add(this.ntxtSalMax);
            this.gbxSalario.Controls.Add(this.ntxtSalMin);
            this.gbxSalario.Controls.Add(this.lblMaxSalario);
            this.gbxSalario.Controls.Add(this.lblMinSalario);
            this.gbxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbxSalario.Location = new System.Drawing.Point(12, 425);
            this.gbxSalario.Name = "gbxSalario";
            this.gbxSalario.Size = new System.Drawing.Size(410, 72);
            this.gbxSalario.TabIndex = 71;
            this.gbxSalario.TabStop = false;
            this.gbxSalario.Text = "Salario";
            // 
            // ntxtSalMax
            // 
            this.ntxtSalMax.AllowDecimalSeparator = false;
            this.ntxtSalMax.AllowNegativeSign = false;
            this.ntxtSalMax.Location = new System.Drawing.Point(251, 30);
            this.ntxtSalMax.Name = "ntxtSalMax";
            this.ntxtSalMax.Size = new System.Drawing.Size(144, 29);
            this.ntxtSalMax.TabIndex = 72;
            // 
            // ntxtSalMin
            // 
            this.ntxtSalMin.AllowDecimalSeparator = false;
            this.ntxtSalMin.AllowNegativeSign = false;
            this.ntxtSalMin.Location = new System.Drawing.Point(52, 30);
            this.ntxtSalMin.Name = "ntxtSalMin";
            this.ntxtSalMin.Size = new System.Drawing.Size(144, 29);
            this.ntxtSalMin.TabIndex = 71;
            // 
            // lblMaxSalario
            // 
            this.lblMaxSalario.AutoSize = true;
            this.lblMaxSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMaxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMaxSalario.Location = new System.Drawing.Point(200, 33);
            this.lblMaxSalario.Name = "lblMaxSalario";
            this.lblMaxSalario.Size = new System.Drawing.Size(55, 24);
            this.lblMaxSalario.TabIndex = 68;
            this.lblMaxSalario.Text = "Max:";
            // 
            // lblMinSalario
            // 
            this.lblMinSalario.AutoSize = true;
            this.lblMinSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMinSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMinSalario.Location = new System.Drawing.Point(3, 33);
            this.lblMinSalario.Name = "lblMinSalario";
            this.lblMinSalario.Size = new System.Drawing.Size(50, 24);
            this.lblMinSalario.TabIndex = 67;
            this.lblMinSalario.Text = "Mín:";
            // 
            // gbxValor
            // 
            this.gbxValor.Controls.Add(this.ntxtValMax);
            this.gbxValor.Controls.Add(this.ntxtValMin);
            this.gbxValor.Controls.Add(this.lblValorMax);
            this.gbxValor.Controls.Add(this.lblValorMin);
            this.gbxValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbxValor.Location = new System.Drawing.Point(12, 503);
            this.gbxValor.Name = "gbxValor";
            this.gbxValor.Size = new System.Drawing.Size(410, 72);
            this.gbxValor.TabIndex = 72;
            this.gbxValor.TabStop = false;
            this.gbxValor.Text = "Valor";
            // 
            // ntxtValMax
            // 
            this.ntxtValMax.AllowDecimalSeparator = false;
            this.ntxtValMax.AllowNegativeSign = false;
            this.ntxtValMax.Location = new System.Drawing.Point(251, 30);
            this.ntxtValMax.Name = "ntxtValMax";
            this.ntxtValMax.Size = new System.Drawing.Size(144, 29);
            this.ntxtValMax.TabIndex = 73;
            // 
            // ntxtValMin
            // 
            this.ntxtValMin.AllowDecimalSeparator = false;
            this.ntxtValMin.AllowNegativeSign = false;
            this.ntxtValMin.Location = new System.Drawing.Point(52, 30);
            this.ntxtValMin.Name = "ntxtValMin";
            this.ntxtValMin.Size = new System.Drawing.Size(144, 29);
            this.ntxtValMin.TabIndex = 72;
            // 
            // lblValorMax
            // 
            this.lblValorMax.AutoSize = true;
            this.lblValorMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValorMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblValorMax.Location = new System.Drawing.Point(199, 33);
            this.lblValorMax.Name = "lblValorMax";
            this.lblValorMax.Size = new System.Drawing.Size(55, 24);
            this.lblValorMax.TabIndex = 68;
            this.lblValorMax.Text = "Max:";
            // 
            // lblValorMin
            // 
            this.lblValorMin.AutoSize = true;
            this.lblValorMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValorMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblValorMin.Location = new System.Drawing.Point(2, 33);
            this.lblValorMin.Name = "lblValorMin";
            this.lblValorMin.Size = new System.Drawing.Size(50, 24);
            this.lblValorMin.TabIndex = 67;
            this.lblValorMin.Text = "Mín:";
            // 
            // gbxEdad
            // 
            this.gbxEdad.Controls.Add(this.cbxEdad);
            this.gbxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbxEdad.Location = new System.Drawing.Point(230, 342);
            this.gbxEdad.Name = "gbxEdad";
            this.gbxEdad.Size = new System.Drawing.Size(192, 72);
            this.gbxEdad.TabIndex = 77;
            this.gbxEdad.TabStop = false;
            this.gbxEdad.Text = "Edad";
            // 
            // gbxPosicion
            // 
            this.gbxPosicion.Controls.Add(this.cbxPosicion);
            this.gbxPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPosicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbxPosicion.Location = new System.Drawing.Point(12, 342);
            this.gbxPosicion.Name = "gbxPosicion";
            this.gbxPosicion.Size = new System.Drawing.Size(203, 72);
            this.gbxPosicion.TabIndex = 76;
            this.gbxPosicion.TabStop = false;
            this.gbxPosicion.Text = "Posición";
            // 
            // cbxPosicion
            // 
            this.cbxPosicion.DropDownWidth = 121;
            this.cbxPosicion.FormattingEnabled = true;
            this.cbxPosicion.IntegralHeight = false;
            this.cbxPosicion.ItemHeight = 24;
            this.cbxPosicion.Items.AddRange(new object[] {
            "ARQ",
            "DEF",
            "MED",
            "VOL",
            "DEL"});
            this.cbxPosicion.Location = new System.Drawing.Point(13, 28);
            this.cbxPosicion.Name = "cbxPosicion";
            this.cbxPosicion.Size = new System.Drawing.Size(176, 32);
            this.cbxPosicion.TabIndex = 0;
            // 
            // gbxNombre
            // 
            this.gbxNombre.Controls.Add(this.txtApellido);
            this.gbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbxNombre.Location = new System.Drawing.Point(12, 262);
            this.gbxNombre.Name = "gbxNombre";
            this.gbxNombre.Size = new System.Drawing.Size(410, 72);
            this.gbxNombre.TabIndex = 75;
            this.gbxNombre.TabStop = false;
            this.gbxNombre.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(13, 28);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(382, 29);
            this.txtApellido.TabIndex = 0;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // gbxFuerza
            // 
            this.gbxFuerza.Controls.Add(this.ntxtFuerMax);
            this.gbxFuerza.Controls.Add(this.ntxtFuerMin);
            this.gbxFuerza.Controls.Add(this.lblFuerzaMax);
            this.gbxFuerza.Controls.Add(this.lblFuerzaMin);
            this.gbxFuerza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFuerza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbxFuerza.Location = new System.Drawing.Point(12, 183);
            this.gbxFuerza.Name = "gbxFuerza";
            this.gbxFuerza.Size = new System.Drawing.Size(410, 72);
            this.gbxFuerza.TabIndex = 74;
            this.gbxFuerza.TabStop = false;
            this.gbxFuerza.Text = "Fuerza";
            // 
            // ntxtFuerMax
            // 
            this.ntxtFuerMax.AllowDecimalSeparator = false;
            this.ntxtFuerMax.AllowNegativeSign = false;
            this.ntxtFuerMax.Location = new System.Drawing.Point(261, 30);
            this.ntxtFuerMax.Name = "ntxtFuerMax";
            this.ntxtFuerMax.Size = new System.Drawing.Size(75, 29);
            this.ntxtFuerMax.TabIndex = 70;
            // 
            // ntxtFuerMin
            // 
            this.ntxtFuerMin.AllowDecimalSeparator = false;
            this.ntxtFuerMin.AllowNegativeSign = false;
            this.ntxtFuerMin.Location = new System.Drawing.Point(106, 30);
            this.ntxtFuerMin.Name = "ntxtFuerMin";
            this.ntxtFuerMin.Size = new System.Drawing.Size(75, 29);
            this.ntxtFuerMin.TabIndex = 69;
            // 
            // lblFuerzaMax
            // 
            this.lblFuerzaMax.AutoSize = true;
            this.lblFuerzaMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFuerzaMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuerzaMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFuerzaMax.Location = new System.Drawing.Point(193, 33);
            this.lblFuerzaMax.Name = "lblFuerzaMax";
            this.lblFuerzaMax.Size = new System.Drawing.Size(55, 24);
            this.lblFuerzaMax.TabIndex = 68;
            this.lblFuerzaMax.Text = "Max:";
            // 
            // lblFuerzaMin
            // 
            this.lblFuerzaMin.AutoSize = true;
            this.lblFuerzaMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFuerzaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuerzaMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFuerzaMin.Location = new System.Drawing.Point(46, 33);
            this.lblFuerzaMin.Name = "lblFuerzaMin";
            this.lblFuerzaMin.Size = new System.Drawing.Size(50, 24);
            this.lblFuerzaMin.TabIndex = 67;
            this.lblFuerzaMin.Text = "Mín:";
            // 
            // cbxEdad
            // 
            this.cbxEdad.DropDownWidth = 121;
            this.cbxEdad.FormattingEnabled = true;
            this.cbxEdad.IntegralHeight = false;
            this.cbxEdad.ItemHeight = 24;
            this.cbxEdad.Items.AddRange(new object[] {
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
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cbxEdad.Location = new System.Drawing.Point(19, 28);
            this.cbxEdad.Name = "cbxEdad";
            this.cbxEdad.Size = new System.Drawing.Size(158, 32);
            this.cbxEdad.TabIndex = 1;
            // 
            // Negociaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1118, 643);
            this.Controls.Add(this.gbxEdad);
            this.Controls.Add(this.gbxValor);
            this.Controls.Add(this.gbxPosicion);
            this.Controls.Add(this.gbxSalario);
            this.Controls.Add(this.gbxNombre);
            this.Controls.Add(this.gbxClub);
            this.Controls.Add(this.gbxFuerza);
            this.Controls.Add(this.btnHacerUnaOferta);
            this.Controls.Add(this.btnComprarJugador);
            this.Controls.Add(this.btnVaciarCampos);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.btnBuscarNegociaciones);
            this.Controls.Add(this.lblNegociaciones);
            this.Controls.Add(this.GrillaJugadoresNegociaciones);
            this.Name = "Negociaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negociaciones";
            this.Load += new System.EventHandler(this.Negociaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaJugadoresNegociaciones)).EndInit();
            this.gbxClub.ResumeLayout(false);
            this.gbxSalario.ResumeLayout(false);
            this.gbxSalario.PerformLayout();
            this.gbxValor.ResumeLayout(false);
            this.gbxValor.PerformLayout();
            this.gbxEdad.ResumeLayout(false);
            this.gbxPosicion.ResumeLayout(false);
            this.gbxNombre.ResumeLayout(false);
            this.gbxNombre.PerformLayout();
            this.gbxFuerza.ResumeLayout(false);
            this.gbxFuerza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaJugadoresNegociaciones;
        private System.Windows.Forms.Label lblNegociaciones;
        private System.Windows.Forms.Button btnBuscarNegociaciones;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.Button btnVaciarCampos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnComprarJugador;
        private System.Windows.Forms.Button btnHacerUnaOferta;
        private System.Windows.Forms.GroupBox gbxClub;
        private System.Windows.Forms.ComboBox cbxClub;
        private System.Windows.Forms.GroupBox gbxSalario;

        private System.Windows.Forms.Label lblMaxSalario;
        private System.Windows.Forms.Label lblMinSalario;
        private System.Windows.Forms.GroupBox gbxValor;

        private System.Windows.Forms.Label lblValorMax;
        private System.Windows.Forms.Label lblValorMin;
        private System.Windows.Forms.GroupBox gbxEdad;
        private System.Windows.Forms.GroupBox gbxPosicion;
        private System.Windows.Forms.ComboBox cbxPosicion;
        private System.Windows.Forms.GroupBox gbxNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox gbxFuerza;
 
        private System.Windows.Forms.Label lblFuerzaMax;
        private System.Windows.Forms.Label lblFuerzaMin;
        private Aga.Controls.NumericTextBox ntxtFuerMin;
        private Aga.Controls.NumericTextBox ntxtFuerMax;
        private Aga.Controls.NumericTextBox ntxtSalMax;
        private Aga.Controls.NumericTextBox ntxtSalMin;
        private Aga.Controls.NumericTextBox ntxtValMax;
        private Aga.Controls.NumericTextBox ntxtValMin;
        private System.Windows.Forms.ComboBox cbxEdad;
    }
}