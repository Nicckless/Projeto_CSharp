namespace Gestor_de_oficina
{
    partial class FormAdicionarServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarServico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerDataSaida = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTipoServico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdivionarServico = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerDataSaida);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxTipoServico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 131);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePickerDataSaida
            // 
            this.dateTimePickerDataSaida.Location = new System.Drawing.Point(13, 96);
            this.dateTimePickerDataSaida.Name = "dateTimePickerDataSaida";
            this.dateTimePickerDataSaida.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDataSaida.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Saída do Veículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Servico:";
            // 
            // textBoxTipoServico
            // 
            this.textBoxTipoServico.Location = new System.Drawing.Point(11, 47);
            this.textBoxTipoServico.Name = "textBoxTipoServico";
            this.textBoxTipoServico.Size = new System.Drawing.Size(443, 22);
            this.textBoxTipoServico.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar os dados do servico";
            // 
            // buttonAdivionarServico
            // 
            this.buttonAdivionarServico.Location = new System.Drawing.Point(2, 149);
            this.buttonAdivionarServico.Name = "buttonAdivionarServico";
            this.buttonAdivionarServico.Size = new System.Drawing.Size(611, 23);
            this.buttonAdivionarServico.TabIndex = 3;
            this.buttonAdivionarServico.Text = "Adicionar Servico";
            this.buttonAdivionarServico.UseVisualStyleBackColor = true;
            this.buttonAdivionarServico.Click += new System.EventHandler(this.buttonAdivionarServico_Click);
            // 
            // FormAdicionarServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 176);
            this.Controls.Add(this.buttonAdivionarServico);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdicionarServico";
            this.Text = "Adicionar servico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdivionarServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTipoServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataSaida;
    }
}