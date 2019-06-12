namespace Gestor_de_oficina
{
    partial class FormAdicionarCarroAluguer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarCarroAluguer));
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNumChassi = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMatricula = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(41, 358);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(321, 82);
            this.buttonAdicionar.TabIndex = 14;
            this.buttonAdicionar.Text = "Adicionar Carro";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMarca);
            this.groupBox1.Controls.Add(this.comboBoxCombustivel);
            this.groupBox1.Controls.Add(this.textBoxModelo);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumChassi);
            this.groupBox1.Controls.Add(this.maskedTextBoxMatricula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 338);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(28, 168);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(321, 22);
            this.textBoxModelo.TabIndex = 15;
            // 
            // maskedTextBoxNumChassi
            // 
            this.maskedTextBoxNumChassi.Location = new System.Drawing.Point(28, 50);
            this.maskedTextBoxNumChassi.Mask = "CCCCCCCCCCCCCCCCC";
            this.maskedTextBoxNumChassi.Name = "maskedTextBoxNumChassi";
            this.maskedTextBoxNumChassi.Size = new System.Drawing.Size(321, 22);
            this.maskedTextBoxNumChassi.TabIndex = 13;
            // 
            // maskedTextBoxMatricula
            // 
            this.maskedTextBoxMatricula.Location = new System.Drawing.Point(28, 290);
            this.maskedTextBoxMatricula.Mask = "CC-CC-CC";
            this.maskedTextBoxMatricula.Name = "maskedTextBoxMatricula";
            this.maskedTextBoxMatricula.Size = new System.Drawing.Size(321, 22);
            this.maskedTextBoxMatricula.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número do Chassi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Combustível";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo";
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Items.AddRange(new object[] {
            "Diesel",
            "Gasolina",
            "Gas",
            "Eletrico"});
            this.comboBoxCombustivel.Location = new System.Drawing.Point(28, 231);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(321, 24);
            this.comboBoxCombustivel.TabIndex = 17;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Abarth",
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Caterham",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Corvette",
            "Dacia",
            "Daewoo",
            "Daihatsu",
            "Dodge",
            "DS",
            "Ferrari",
            "Fiat",
            "Ford",
            "Galloper",
            "Honda",
            "Hummer",
            "Hyundai",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lada",
            "Lamborghini",
            "Lancia",
            "Land Rover",
            "Lexux",
            "Lotus",
            "Maserati",
            "Maybach",
            "Mazda",
            "Mercedes-Benz",
            "MG",
            "MINI",
            "Mitsubishi",
            "Morgan",
            "Nissan",
            "Opel",
            "Peugeot",
            "Porsche",
            "Renault",
            "Rolls-Royce",
            "Rover",
            "Saab",
            "Seat",
            "Skoda",
            "Smart",
            "SsangYong",
            "Subaru",
            "Suzuki",
            "Tata",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.comboBoxMarca.Location = new System.Drawing.Point(28, 108);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(321, 24);
            this.comboBoxMarca.TabIndex = 18;
            // 
            // FormAdicionarCarroAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 455);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdicionarCarroAluguer";
            this.Text = "Adicionar um carro para aluguer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumChassi;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.ComboBox comboBoxMarca;
    }
}