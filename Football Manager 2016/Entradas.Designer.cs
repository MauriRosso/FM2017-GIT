namespace Football_Manager_2016
{
    partial class Entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entradas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPopulares = new System.Windows.Forms.Label();
            this.lblPlateas = new System.Windows.Forms.Label();
            this.lblPalcos = new System.Windows.Forms.Label();
            this.upPopulares = new System.Windows.Forms.NumericUpDown();
            this.upPlateas = new System.Windows.Forms.NumericUpDown();
            this.upPalcos = new System.Windows.Forms.NumericUpDown();
            this.btnEntradasActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPopulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPlateas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPalcos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 215);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPopulares
            // 
            this.lblPopulares.AutoSize = true;
            this.lblPopulares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPopulares.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopulares.Location = new System.Drawing.Point(12, 9);
            this.lblPopulares.Name = "lblPopulares";
            this.lblPopulares.Size = new System.Drawing.Size(89, 18);
            this.lblPopulares.TabIndex = 1;
            this.lblPopulares.Text = "Populares:";
            // 
            // lblPlateas
            // 
            this.lblPlateas.AutoSize = true;
            this.lblPlateas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPlateas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateas.Location = new System.Drawing.Point(212, 9);
            this.lblPlateas.Name = "lblPlateas";
            this.lblPlateas.Size = new System.Drawing.Size(69, 18);
            this.lblPlateas.TabIndex = 2;
            this.lblPlateas.Text = "Plateas:";
            // 
            // lblPalcos
            // 
            this.lblPalcos.AutoSize = true;
            this.lblPalcos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPalcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalcos.Location = new System.Drawing.Point(391, 9);
            this.lblPalcos.Name = "lblPalcos";
            this.lblPalcos.Size = new System.Drawing.Size(65, 18);
            this.lblPalcos.TabIndex = 3;
            this.lblPalcos.Text = "Palcos:";
            // 
            // upPopulares
            // 
            this.upPopulares.Location = new System.Drawing.Point(108, 9);
            this.upPopulares.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.upPopulares.Name = "upPopulares";
            this.upPopulares.Size = new System.Drawing.Size(82, 20);
            this.upPopulares.TabIndex = 4;
            // 
            // upPlateas
            // 
            this.upPlateas.Location = new System.Drawing.Point(287, 9);
            this.upPlateas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.upPlateas.Name = "upPlateas";
            this.upPlateas.Size = new System.Drawing.Size(82, 20);
            this.upPlateas.TabIndex = 5;
            // 
            // upPalcos
            // 
            this.upPalcos.Location = new System.Drawing.Point(462, 9);
            this.upPalcos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.upPalcos.Name = "upPalcos";
            this.upPalcos.Size = new System.Drawing.Size(82, 20);
            this.upPalcos.TabIndex = 6;
            // 
            // btnEntradasActualizar
            // 
            this.btnEntradasActualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEntradasActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradasActualizar.Location = new System.Drawing.Point(186, 154);
            this.btnEntradasActualizar.Name = "btnEntradasActualizar";
            this.btnEntradasActualizar.Size = new System.Drawing.Size(161, 40);
            this.btnEntradasActualizar.TabIndex = 7;
            this.btnEntradasActualizar.Text = "Actualizar Precios";
            this.btnEntradasActualizar.UseVisualStyleBackColor = false;
            this.btnEntradasActualizar.Click += new System.EventHandler(this.btnEntradasActualizar_Click);
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 215);
            this.Controls.Add(this.btnEntradasActualizar);
            this.Controls.Add(this.upPalcos);
            this.Controls.Add(this.upPlateas);
            this.Controls.Add(this.upPopulares);
            this.Controls.Add(this.lblPalcos);
            this.Controls.Add(this.lblPlateas);
            this.Controls.Add(this.lblPopulares);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Entradas";
            this.Text = "Entradas";
            this.Load += new System.EventHandler(this.Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPopulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPlateas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPalcos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPopulares;
        private System.Windows.Forms.Label lblPlateas;
        private System.Windows.Forms.Label lblPalcos;
        private System.Windows.Forms.NumericUpDown upPopulares;
        private System.Windows.Forms.NumericUpDown upPlateas;
        private System.Windows.Forms.NumericUpDown upPalcos;
        private System.Windows.Forms.Button btnEntradasActualizar;
    }
}