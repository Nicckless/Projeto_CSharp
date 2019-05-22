namespace Gestor_de_oficina
{
    partial class FormAdicionarCarroOficina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxKMs = new System.Windows.Forms.TextBox();
            this.maskedTextBoxMatricula = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxNumeroChassis = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdicionarCarroOficina = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxKMs);
            this.panel1.Controls.Add(this.maskedTextBoxMatricula);
            this.panel1.Controls.Add(this.comboBoxCombustivel);
            this.panel1.Controls.Add(this.comboBoxModelo);
            this.panel1.Controls.Add(this.comboBoxMarca);
            this.panel1.Controls.Add(this.maskedTextBoxNumeroChassis);
            this.panel1.Controls.Add(this.buttonAdicionarCarroOficina);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 509);
            this.panel1.TabIndex = 0;
            // 
            // textBoxKMs
            // 
            this.textBoxKMs.Location = new System.Drawing.Point(15, 370);
            this.textBoxKMs.Name = "textBoxKMs";
            this.textBoxKMs.Size = new System.Drawing.Size(404, 22);
            this.textBoxKMs.TabIndex = 19;
            // 
            // maskedTextBoxMatricula
            // 
            this.maskedTextBoxMatricula.Location = new System.Drawing.Point(15, 301);
            this.maskedTextBoxMatricula.Mask = "CC-CC-CC";
            this.maskedTextBoxMatricula.Name = "maskedTextBoxMatricula";
            this.maskedTextBoxMatricula.Size = new System.Drawing.Size(404, 22);
            this.maskedTextBoxMatricula.TabIndex = 18;
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Location = new System.Drawing.Point(15, 239);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(404, 24);
            this.comboBoxCombustivel.TabIndex = 17;
            // 
            // comboBoxModelo
            // 
            this.comboBoxModelo.FormattingEnabled = true;
            this.comboBoxModelo.Location = new System.Drawing.Point(15, 180);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(404, 24);
            this.comboBoxModelo.TabIndex = 16;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(15, 121);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(404, 24);
            this.comboBoxMarca.TabIndex = 15;
            // 
            // maskedTextBoxNumeroChassis
            // 
            this.maskedTextBoxNumeroChassis.Location = new System.Drawing.Point(15, 61);
            this.maskedTextBoxNumeroChassis.Mask = "CCCCCCCCCCCCCCCCC";
            this.maskedTextBoxNumeroChassis.Name = "maskedTextBoxNumeroChassis";
            this.maskedTextBoxNumeroChassis.Size = new System.Drawing.Size(404, 22);
            this.maskedTextBoxNumeroChassis.TabIndex = 14;
            // 
            // buttonAdicionarCarroOficina
            // 
            this.buttonAdicionarCarroOficina.Location = new System.Drawing.Point(15, 406);
            this.buttonAdicionarCarroOficina.Name = "buttonAdicionarCarroOficina";
            this.buttonAdicionarCarroOficina.Size = new System.Drawing.Size(404, 90);
            this.buttonAdicionarCarroOficina.TabIndex = 13;
            this.buttonAdicionarCarroOficina.Text = "Adicionar um novo carro";
            this.buttonAdicionarCarroOficina.UseVisualStyleBackColor = true;
            this.buttonAdicionarCarroOficina.Click += new System.EventHandler(this.buttonAdicionarCarroOficina_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quilometros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Matricula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Combustivel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero Chassis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar um carro a Oficina";
            // 
            // FormAdicionarCarroOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 533);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdicionarCarroOficina";
            this.Text = "FormAdicionarCarroOficina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdicionarCarroOficina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumeroChassis;
        private System.Windows.Forms.TextBox textBoxKMs;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatricula;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
    }
}