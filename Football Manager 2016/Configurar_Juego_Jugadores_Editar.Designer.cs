namespace Football_Manager_2016
{
    partial class Configurar_Juego_Jugadores_Editar
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
            this.lblJugador = new System.Windows.Forms.Label();
            this.btnModificarJug = new System.Windows.Forms.Button();
            this.ntxtConfigValor = new Aga.Controls.NumericTextBox();
            this.ntxtConfigSalario = new Aga.Controls.NumericTextBox();
            this.cbxConfigClub = new System.Windows.Forms.ComboBox();
            this.cbxConfigPie = new System.Windows.Forms.ComboBox();
            this.cbxConfigEdad = new System.Windows.Forms.ComboBox();
            this.cbxConfigFuerza = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfigNombre = new System.Windows.Forms.TextBox();
            this.cbxConfigPosicion = new System.Windows.Forms.ComboBox();
            this.lblConfigEdad = new System.Windows.Forms.Label();
            this.lblConfigValor = new System.Windows.Forms.Label();
            this.lblConfigSalario = new System.Windows.Forms.Label();
            this.lblConfigPie = new System.Windows.Forms.Label();
            this.lblConfigFuerza = new System.Windows.Forms.Label();
            this.lblConfigNombre = new System.Windows.Forms.Label();
            this.lblConfigPosicion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.BackColor = System.Drawing.Color.Transparent;
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblJugador.Location = new System.Drawing.Point(222, 25);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(126, 29);
            this.lblJugador.TabIndex = 67;
            this.lblJugador.Text = "(Jugador)";
            // 
            // btnModificarJug
            // 
            this.btnModificarJug.BackColor = System.Drawing.Color.Teal;
            this.btnModificarJug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarJug.ForeColor = System.Drawing.Color.White;
            this.btnModificarJug.Location = new System.Drawing.Point(272, 453);
            this.btnModificarJug.Name = "btnModificarJug";
            this.btnModificarJug.Size = new System.Drawing.Size(153, 43);
            this.btnModificarJug.TabIndex = 66;
            this.btnModificarJug.Text = "Modificar";
            this.btnModificarJug.UseVisualStyleBackColor = false;
            this.btnModificarJug.Click += new System.EventHandler(this.btnModificarJug_Click);
            // 
            // ntxtConfigValor
            // 
            this.ntxtConfigValor.AllowDecimalSeparator = false;
            this.ntxtConfigValor.AllowNegativeSign = false;
            this.ntxtConfigValor.Location = new System.Drawing.Point(335, 223);
            this.ntxtConfigValor.Name = "ntxtConfigValor";
            this.ntxtConfigValor.Size = new System.Drawing.Size(144, 20);
            this.ntxtConfigValor.TabIndex = 83;
            // 
            // ntxtConfigSalario
            // 
            this.ntxtConfigSalario.AllowDecimalSeparator = false;
            this.ntxtConfigSalario.AllowNegativeSign = false;
            this.ntxtConfigSalario.Location = new System.Drawing.Point(335, 178);
            this.ntxtConfigSalario.Name = "ntxtConfigSalario";
            this.ntxtConfigSalario.Size = new System.Drawing.Size(144, 20);
            this.ntxtConfigSalario.TabIndex = 82;
            // 
            // cbxConfigClub
            // 
            this.cbxConfigClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConfigClub.FormattingEnabled = true;
            this.cbxConfigClub.Items.AddRange(new object[] {
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
            this.cbxConfigClub.Location = new System.Drawing.Point(335, 397);
            this.cbxConfigClub.Name = "cbxConfigClub";
            this.cbxConfigClub.Size = new System.Drawing.Size(145, 21);
            this.cbxConfigClub.TabIndex = 81;
            // 
            // cbxConfigPie
            // 
            this.cbxConfigPie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConfigPie.FormattingEnabled = true;
            this.cbxConfigPie.Items.AddRange(new object[] {
            "IZQ",
            "DER"});
            this.cbxConfigPie.Location = new System.Drawing.Point(336, 354);
            this.cbxConfigPie.Name = "cbxConfigPie";
            this.cbxConfigPie.Size = new System.Drawing.Size(59, 21);
            this.cbxConfigPie.TabIndex = 80;
            // 
            // cbxConfigEdad
            // 
            this.cbxConfigEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConfigEdad.FormattingEnabled = true;
            this.cbxConfigEdad.Items.AddRange(new object[] {
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
            this.cbxConfigEdad.Location = new System.Drawing.Point(335, 308);
            this.cbxConfigEdad.Name = "cbxConfigEdad";
            this.cbxConfigEdad.Size = new System.Drawing.Size(90, 21);
            this.cbxConfigEdad.TabIndex = 79;
            // 
            // cbxConfigFuerza
            // 
            this.cbxConfigFuerza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConfigFuerza.FormattingEnabled = true;
            this.cbxConfigFuerza.Items.AddRange(new object[] {
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
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cbxConfigFuerza.Location = new System.Drawing.Point(335, 265);
            this.cbxConfigFuerza.Name = "cbxConfigFuerza";
            this.cbxConfigFuerza.Size = new System.Drawing.Size(90, 21);
            this.cbxConfigFuerza.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 77;
            this.label1.Text = "Club:";
            // 
            // txtConfigNombre
            // 
            this.txtConfigNombre.Location = new System.Drawing.Point(335, 136);
            this.txtConfigNombre.Name = "txtConfigNombre";
            this.txtConfigNombre.Size = new System.Drawing.Size(145, 20);
            this.txtConfigNombre.TabIndex = 76;
            // 
            // cbxConfigPosicion
            // 
            this.cbxConfigPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConfigPosicion.FormattingEnabled = true;
            this.cbxConfigPosicion.Items.AddRange(new object[] {
            "ARQ",
            "DEF",
            "MED",
            "VOL",
            "DEL"});
            this.cbxConfigPosicion.Location = new System.Drawing.Point(336, 94);
            this.cbxConfigPosicion.Name = "cbxConfigPosicion";
            this.cbxConfigPosicion.Size = new System.Drawing.Size(90, 21);
            this.cbxConfigPosicion.TabIndex = 75;
            // 
            // lblConfigEdad
            // 
            this.lblConfigEdad.AutoSize = true;
            this.lblConfigEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConfigEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigEdad.ForeColor = System.Drawing.Color.White;
            this.lblConfigEdad.Location = new System.Drawing.Point(264, 308);
            this.lblConfigEdad.Name = "lblConfigEdad";
            this.lblConfigEdad.Size = new System.Drawing.Size(65, 24);
            this.lblConfigEdad.TabIndex = 74;
            this.lblConfigEdad.Text = "Edad:";
            // 
            // lblConfigValor
            // 
            this.lblConfigValor.AutoSize = true;
            this.lblConfigValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConfigValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigValor.ForeColor = System.Drawing.Color.White;
            this.lblConfigValor.Location = new System.Drawing.Point(264, 220);
            this.lblConfigValor.Name = "lblConfigValor";
            this.lblConfigValor.Size = new System.Drawing.Size(65, 24);
            this.lblConfigValor.TabIndex = 73;
            this.lblConfigValor.Text = "Valor:";
            // 
            // lblConfigSalario
            // 
            this.lblConfigSalario.AutoSize = true;
            this.lblConfigSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConfigSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigSalario.ForeColor = System.Drawing.Color.White;
            this.lblConfigSalario.Location = new System.Drawing.Point(249, 176);
            this.lblConfigSalario.Name = "lblConfigSalario";
            this.lblConfigSalario.Size = new System.Drawing.Size(80, 24);
            this.lblConfigSalario.TabIndex = 72;
            this.lblConfigSalario.Text = "Salario:";
            // 
            // lblConfigPie
            // 
            this.lblConfigPie.AutoSize = true;
            this.lblConfigPie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConfigPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigPie.ForeColor = System.Drawing.Color.White;
            this.lblConfigPie.Location = new System.Drawing.Point(283, 352);
            this.lblConfigPie.Name = "lblConfigPie";
            this.lblConfigPie.Size = new System.Drawing.Size(46, 24);
            this.lblConfigPie.TabIndex = 71;
            this.lblConfigPie.Text = "Pie:";
            // 
            // lblConfigFuerza
            // 
            this.lblConfigFuerza.AutoSize = true;
            this.lblConfigFuerza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConfigFuerza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigFuerza.ForeColor = System.Drawing.Color.White;
            this.lblConfigFuerza.Location = new System.Drawing.Point(248, 262);
            this.lblConfigFuerza.Name = "lblConfigFuerza";
            this.lblConfigFuerza.Size = new System.Drawing.Size(81, 24);
            this.lblConfigFuerza.TabIndex = 70;
            this.lblConfigFuerza.Text = "Fuerza:";
            // 
            // lblConfigNombre
            // 
            this.lblConfigNombre.AutoSize = true;
            this.lblConfigNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConfigNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigNombre.ForeColor = System.Drawing.Color.White;
            this.lblConfigNombre.Location = new System.Drawing.Point(238, 132);
            this.lblConfigNombre.Name = "lblConfigNombre";
            this.lblConfigNombre.Size = new System.Drawing.Size(91, 24);
            this.lblConfigNombre.TabIndex = 69;
            this.lblConfigNombre.Text = "Nombre:";
            // 
            // lblConfigPosicion
            // 
            this.lblConfigPosicion.AutoSize = true;
            this.lblConfigPosicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblConfigPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigPosicion.ForeColor = System.Drawing.Color.White;
            this.lblConfigPosicion.Location = new System.Drawing.Point(233, 89);
            this.lblConfigPosicion.Name = "lblConfigPosicion";
            this.lblConfigPosicion.Size = new System.Drawing.Size(96, 24);
            this.lblConfigPosicion.TabIndex = 68;
            this.lblConfigPosicion.Text = "Posición:";
            // 
            // Configurar_Juego_Jugadores_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 508);
            this.Controls.Add(this.ntxtConfigValor);
            this.Controls.Add(this.ntxtConfigSalario);
            this.Controls.Add(this.cbxConfigClub);
            this.Controls.Add(this.cbxConfigPie);
            this.Controls.Add(this.cbxConfigEdad);
            this.Controls.Add(this.cbxConfigFuerza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfigNombre);
            this.Controls.Add(this.cbxConfigPosicion);
            this.Controls.Add(this.lblConfigEdad);
            this.Controls.Add(this.lblConfigValor);
            this.Controls.Add(this.lblConfigSalario);
            this.Controls.Add(this.lblConfigPie);
            this.Controls.Add(this.lblConfigFuerza);
            this.Controls.Add(this.lblConfigNombre);
            this.Controls.Add(this.lblConfigPosicion);
            this.Controls.Add(this.lblJugador);
            this.Controls.Add(this.btnModificarJug);
            this.Name = "Configurar_Juego_Jugadores_Editar";
            this.Text = "Configurar_Juego_Jugadores_Editar";
            this.Load += new System.EventHandler(this.Configurar_Juego_Jugadores_Editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Button btnModificarJug;
        private Aga.Controls.NumericTextBox ntxtConfigValor;
        private Aga.Controls.NumericTextBox ntxtConfigSalario;
        private System.Windows.Forms.ComboBox cbxConfigClub;
        private System.Windows.Forms.ComboBox cbxConfigPie;
        private System.Windows.Forms.ComboBox cbxConfigEdad;
        private System.Windows.Forms.ComboBox cbxConfigFuerza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfigNombre;
        private System.Windows.Forms.ComboBox cbxConfigPosicion;
        private System.Windows.Forms.Label lblConfigEdad;
        private System.Windows.Forms.Label lblConfigValor;
        private System.Windows.Forms.Label lblConfigSalario;
        private System.Windows.Forms.Label lblConfigPie;
        private System.Windows.Forms.Label lblConfigFuerza;
        private System.Windows.Forms.Label lblConfigNombre;
        private System.Windows.Forms.Label lblConfigPosicion;
    }
}