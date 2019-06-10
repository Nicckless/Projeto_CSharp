namespace Gestor_de_oficina
{
    partial class FormEditarCarroVenda
    {
        /// <summary>
        /// Required designer varvariable.
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
            this.components = new System.ComponentModel.Container();
            this.buttonEditarCarro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAddExtra = new System.Windows.Forms.Button();
            this.listBoxExtras = new System.Windows.Forms.ListBox();
            this.textBoxExtra = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCombustivel = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxNumChassi = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEditarCarro
            // 
            this.buttonEditarCarro.Location = new System.Drawing.Point(40, 285);
            this.buttonEditarCarro.Name = "buttonEditarCarro";
            this.buttonEditarCarro.Size = new System.Drawing.Size(321, 128);
            this.buttonEditarCarro.TabIndex = 20;
            this.buttonEditarCarro.Text = "Editar Carro";
            this.buttonEditarCarro.UseVisualStyleBackColor = true;
            this.buttonEditarCarro.Click += new System.EventHandler(this.buttonEditarCarro_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.buttonAddExtra);
            this.groupBox2.Controls.Add(this.listBoxExtras);
            this.groupBox2.Controls.Add(this.textBoxExtra);
            this.groupBox2.Location = new System.Drawing.Point(393, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 403);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(314, 19);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 16;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonAddExtra
            // 
            this.buttonAddExtra.Location = new System.Drawing.Point(217, 19);
            this.buttonAddExtra.Name = "buttonAddExtra";
            this.buttonAddExtra.Size = new System.Drawing.Size(75, 23);
            this.buttonAddExtra.TabIndex = 15;
            this.buttonAddExtra.Text = "Adicionar";
            this.buttonAddExtra.UseVisualStyleBackColor = true;
            // 
            // listBoxExtras
            // 
            this.listBoxExtras.FormattingEnabled = true;
            this.listBoxExtras.ItemHeight = 16;
            this.listBoxExtras.Location = new System.Drawing.Point(7, 48);
            this.listBoxExtras.Name = "listBoxExtras";
            this.listBoxExtras.Size = new System.Drawing.Size(382, 340);
            this.listBoxExtras.TabIndex = 14;
            // 
            // textBoxExtra
            // 
            this.textBoxExtra.Location = new System.Drawing.Point(7, 20);
            this.textBoxExtra.Name = "textBoxExtra";
            this.textBoxExtra.Size = new System.Drawing.Size(204, 22);
            this.textBoxExtra.TabIndex = 13;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Gestor_de_oficina.CarroVenda);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCombustivel);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumChassi);
            this.groupBox1.Controls.Add(this.comboBoxModelo);
            this.groupBox1.Controls.Add(this.comboBoxMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 269);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxCombustivel
            // 
            this.comboBoxCombustivel.DataSource = this.bindingSource1;
            this.comboBoxCombustivel.DisplayMember = "Combustivel";
            this.comboBoxCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCombustivel.FormattingEnabled = true;
            this.comboBoxCombustivel.Location = new System.Drawing.Point(28, 231);
            this.comboBoxCombustivel.Name = "comboBoxCombustivel";
            this.comboBoxCombustivel.Size = new System.Drawing.Size(321, 24);
            this.comboBoxCombustivel.TabIndex = 14;
            // 
            // maskedTextBoxNumChassi
            // 
            this.maskedTextBoxNumChassi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "NumeroChassis", true));
            this.maskedTextBoxNumChassi.Location = new System.Drawing.Point(28, 50);
            this.maskedTextBoxNumChassi.Mask = "CCCCCCCCCCCCCCCCC";
            this.maskedTextBoxNumChassi.Name = "maskedTextBoxNumChassi";
            this.maskedTextBoxNumChassi.Size = new System.Drawing.Size(321, 22);
            this.maskedTextBoxNumChassi.TabIndex = 13;
            // 
            // comboBoxModelo
            // 
            this.comboBoxModelo.DataSource = this.bindingSource1;
            this.comboBoxModelo.DisplayMember = "Modelo";
            this.comboBoxModelo.FormattingEnabled = true;
            this.comboBoxModelo.Location = new System.Drawing.Point(28, 168);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(321, 24);
            this.comboBoxModelo.TabIndex = 11;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DataSource = this.bindingSource1;
            this.comboBoxMarca.DisplayMember = "Marca";
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(28, 108);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(321, 24);
            this.comboBoxMarca.TabIndex = 10;
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
            // FormEditarCarroVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 427);
            this.Controls.Add(this.buttonEditarCarro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEditarCarroVenda";
            this.Text = "FormEditarVenda";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditarCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAddExtra;
        private System.Windows.Forms.ListBox listBoxExtras;
        private System.Windows.Forms.TextBox textBoxExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCombustivel;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumChassi;
        private System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}