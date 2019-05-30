namespace Gestor_de_oficina
{
    partial class FormAluguer
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
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCarrosAluguer = new System.Windows.Forms.DataGridView();
            this.idCarroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroChassisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTotaldias = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.buttonAlugar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKmandtes = new System.Windows.Forms.TextBox();
            this.buttonDevolver = new System.Windows.Forms.Button();
            this.carroAluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.listBoxAlugueres = new System.Windows.Forms.ListBox();
            this.aluguerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrosAluguer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewCarrosAluguer);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(318, 11);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(830, 262);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Carros para Alugar";
            // 
            // dataGridViewCarrosAluguer
            // 
            this.dataGridViewCarrosAluguer.AutoGenerateColumns = false;
            this.dataGridViewCarrosAluguer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrosAluguer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarroDataGridViewTextBoxColumn,
            this.numeroChassisDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.combustivelDataGridViewTextBoxColumn});
            this.dataGridViewCarrosAluguer.DataSource = this.carroBindingSource;
            this.dataGridViewCarrosAluguer.Location = new System.Drawing.Point(274, 21);
            this.dataGridViewCarrosAluguer.Name = "dataGridViewCarrosAluguer";
            this.dataGridViewCarrosAluguer.RowTemplate.Height = 24;
            this.dataGridViewCarrosAluguer.Size = new System.Drawing.Size(549, 229);
            this.dataGridViewCarrosAluguer.TabIndex = 4;
            // 
            // idCarroDataGridViewTextBoxColumn
            // 
            this.idCarroDataGridViewTextBoxColumn.DataPropertyName = "IdCarro";
            this.idCarroDataGridViewTextBoxColumn.HeaderText = "IdCarro";
            this.idCarroDataGridViewTextBoxColumn.Name = "idCarroDataGridViewTextBoxColumn";
            // 
            // numeroChassisDataGridViewTextBoxColumn
            // 
            this.numeroChassisDataGridViewTextBoxColumn.DataPropertyName = "NumeroChassis";
            this.numeroChassisDataGridViewTextBoxColumn.HeaderText = "NumeroChassis";
            this.numeroChassisDataGridViewTextBoxColumn.Name = "numeroChassisDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            // 
            // combustivelDataGridViewTextBoxColumn
            // 
            this.combustivelDataGridViewTextBoxColumn.DataPropertyName = "Combustivel";
            this.combustivelDataGridViewTextBoxColumn.HeaderText = "Combustivel";
            this.combustivelDataGridViewTextBoxColumn.Name = "combustivelDataGridViewTextBoxColumn";
            // 
            // carroBindingSource
            // 
            this.carroBindingSource.DataSource = typeof(Gestor_de_oficina.Carro);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marca";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkedListBox1);
            this.groupBox4.Location = new System.Drawing.Point(6, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 101);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Combustivel";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Diesel",
            "Gasolina",
            "Gás",
            "Elétricos"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(250, 72);
            this.checkedListBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 58);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modelo";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 560);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um cliente";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.DataSource = this.clienteBindingSource;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(6, 21);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(288, 532);
            this.listBoxClientes.TabIndex = 1;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Gestor_de_oficina.Cliente);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.labelTotaldias);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.dateTimePicker2);
            this.groupBox6.Controls.Add(this.buttonAlugar);
            this.groupBox6.Location = new System.Drawing.Point(318, 279);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(413, 292);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alugar Carro";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelTotaldias
            // 
            this.labelTotaldias.AutoSize = true;
            this.labelTotaldias.Location = new System.Drawing.Point(271, 85);
            this.labelTotaldias.Name = "labelTotaldias";
            this.labelTotaldias.Size = new System.Drawing.Size(46, 17);
            this.labelTotaldias.TabIndex = 7;
            this.labelTotaldias.Text = "0 dias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duração do aluguer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de terminio de aluguer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data de inicio de aluguer";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(35, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // buttonAlugar
            // 
            this.buttonAlugar.Location = new System.Drawing.Point(12, 225);
            this.buttonAlugar.Name = "buttonAlugar";
            this.buttonAlugar.Size = new System.Drawing.Size(379, 60);
            this.buttonAlugar.TabIndex = 0;
            this.buttonAlugar.Text = "Alugar Carro";
            this.buttonAlugar.UseVisualStyleBackColor = true;
            this.buttonAlugar.Click += new System.EventHandler(this.buttonAlugar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.textBoxKmandtes);
            this.groupBox7.Controls.Add(this.buttonDevolver);
            this.groupBox7.Location = new System.Drawing.Point(737, 279);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(411, 292);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Devolver Carro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Km";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Km feitos";
            // 
            // textBoxKmandtes
            // 
            this.textBoxKmandtes.Location = new System.Drawing.Point(32, 57);
            this.textBoxKmandtes.Name = "textBoxKmandtes";
            this.textBoxKmandtes.Size = new System.Drawing.Size(172, 22);
            this.textBoxKmandtes.TabIndex = 9;
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.Location = new System.Drawing.Point(12, 225);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(377, 60);
            this.buttonDevolver.TabIndex = 1;
            this.buttonDevolver.Text = "Devolver Carro / Emitir Fatura";
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonDevolver_Click);
            // 
            // carroAluguerBindingSource
            // 
            this.carroAluguerBindingSource.DataSource = typeof(Gestor_de_oficina.CarroAluguer);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.listBoxAlugueres);
            this.groupBox8.Location = new System.Drawing.Point(1154, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(314, 559);
            this.groupBox8.TabIndex = 17;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Alugueres do cliente";
            // 
            // listBoxAlugueres
            // 
            this.listBoxAlugueres.DataSource = this.aluguerBindingSource;
            this.listBoxAlugueres.FormattingEnabled = true;
            this.listBoxAlugueres.ItemHeight = 16;
            this.listBoxAlugueres.Location = new System.Drawing.Point(6, 20);
            this.listBoxAlugueres.Name = "listBoxAlugueres";
            this.listBoxAlugueres.Size = new System.Drawing.Size(302, 532);
            this.listBoxAlugueres.TabIndex = 0;
            // 
            // aluguerBindingSource
            // 
            this.aluguerBindingSource.DataSource = typeof(Gestor_de_oficina.Aluguer);
            // 
            // FormAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1480, 583);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAluguer";
            this.Text = "FormAluguer";
            this.Load += new System.EventHandler(this.FormAluguer_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrosAluguer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carroAluguerBindingSource)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aluguerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewCarrosAluguer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTotaldias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button buttonAlugar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKmandtes;
        private System.Windows.Forms.Button buttonDevolver;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroChassisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carroBindingSource;
        private System.Windows.Forms.BindingSource carroAluguerBindingSource;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListBox listBoxAlugueres;
        private System.Windows.Forms.BindingSource aluguerBindingSource;
    }
}