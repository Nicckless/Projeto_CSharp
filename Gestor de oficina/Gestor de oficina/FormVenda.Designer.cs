namespace Gestor_de_oficina
{
    partial class FormVenda
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCliente = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFiltrarListaCarros = new System.Windows.Forms.Button();
            this.buttonEditarCarroVenda = new System.Windows.Forms.Button();
            this.buttonEliminarCarroVenda = new System.Windows.Forms.Button();
            this.listBoxCarrosVenda = new System.Windows.Forms.ListBox();
            this.buttonVender = new System.Windows.Forms.Button();
            this.checkedListBoxFiltrarCombustivel = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEliminarVenda = new System.Windows.Forms.Button();
            this.listBoxVendas = new System.Windows.Forms.ListBox();
            this.buttonFiltrarListaClientes = new System.Windows.Forms.Button();
            this.textBoxFiltrarNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFiltrarModelo = new System.Windows.Forms.TextBox();
            this.textBoxFiltrarMarca = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBoxCliente);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 393);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecionar cliente";
            // 
            // listBoxCliente
            // 
            this.listBoxCliente.FormattingEnabled = true;
            this.listBoxCliente.ItemHeight = 16;
            this.listBoxCliente.Location = new System.Drawing.Point(3, 19);
            this.listBoxCliente.Name = "listBoxCliente";
            this.listBoxCliente.Size = new System.Drawing.Size(258, 372);
            this.listBoxCliente.TabIndex = 1;
            this.listBoxCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxCliente_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(282, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 443);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxFiltrarMarca);
            this.panel3.Controls.Add(this.textBoxFiltrarModelo);
            this.panel3.Controls.Add(this.buttonFiltrarListaCarros);
            this.panel3.Controls.Add(this.buttonEditarCarroVenda);
            this.panel3.Controls.Add(this.buttonEliminarCarroVenda);
            this.panel3.Controls.Add(this.listBoxCarrosVenda);
            this.panel3.Controls.Add(this.buttonVender);
            this.panel3.Controls.Add(this.checkedListBoxFiltrarCombustivel);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 414);
            this.panel3.TabIndex = 0;
            // 
            // buttonFiltrarListaCarros
            // 
            this.buttonFiltrarListaCarros.Location = new System.Drawing.Point(15, 255);
            this.buttonFiltrarListaCarros.Name = "buttonFiltrarListaCarros";
            this.buttonFiltrarListaCarros.Size = new System.Drawing.Size(188, 23);
            this.buttonFiltrarListaCarros.TabIndex = 21;
            this.buttonFiltrarListaCarros.Text = "Filtrar";
            this.buttonFiltrarListaCarros.UseVisualStyleBackColor = true;
            this.buttonFiltrarListaCarros.Click += new System.EventHandler(this.buttonFiltrarListaCarros_Click);
            // 
            // buttonEditarCarroVenda
            // 
            this.buttonEditarCarroVenda.Location = new System.Drawing.Point(209, 382);
            this.buttonEditarCarroVenda.Name = "buttonEditarCarroVenda";
            this.buttonEditarCarroVenda.Size = new System.Drawing.Size(521, 23);
            this.buttonEditarCarroVenda.TabIndex = 20;
            this.buttonEditarCarroVenda.Text = "Editar";
            this.buttonEditarCarroVenda.UseVisualStyleBackColor = true;
            this.buttonEditarCarroVenda.Click += new System.EventHandler(this.buttonEditarCarroVenda_Click);
            // 
            // buttonEliminarCarroVenda
            // 
            this.buttonEliminarCarroVenda.Location = new System.Drawing.Point(209, 353);
            this.buttonEliminarCarroVenda.Name = "buttonEliminarCarroVenda";
            this.buttonEliminarCarroVenda.Size = new System.Drawing.Size(521, 23);
            this.buttonEliminarCarroVenda.TabIndex = 3;
            this.buttonEliminarCarroVenda.Text = "Eliminar";
            this.buttonEliminarCarroVenda.UseVisualStyleBackColor = true;
            this.buttonEliminarCarroVenda.Click += new System.EventHandler(this.buttonEliminarCarroVenda_Click);
            // 
            // listBoxCarrosVenda
            // 
            this.listBoxCarrosVenda.FormattingEnabled = true;
            this.listBoxCarrosVenda.ItemHeight = 16;
            this.listBoxCarrosVenda.Location = new System.Drawing.Point(209, 21);
            this.listBoxCarrosVenda.Name = "listBoxCarrosVenda";
            this.listBoxCarrosVenda.Size = new System.Drawing.Size(521, 292);
            this.listBoxCarrosVenda.TabIndex = 19;
            this.listBoxCarrosVenda.SelectedIndexChanged += new System.EventHandler(this.listBoxCarrosVenda_SelectedIndexChanged);
            // 
            // buttonVender
            // 
            this.buttonVender.Location = new System.Drawing.Point(209, 319);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(521, 28);
            this.buttonVender.TabIndex = 2;
            this.buttonVender.Text = "Vender Carro";
            this.buttonVender.UseVisualStyleBackColor = true;
            this.buttonVender.Click += new System.EventHandler(this.buttonVender_Click);
            // 
            // checkedListBoxFiltrarCombustivel
            // 
            this.checkedListBoxFiltrarCombustivel.FormattingEnabled = true;
            this.checkedListBoxFiltrarCombustivel.Items.AddRange(new object[] {
            "Diesel",
            "Gasolina",
            "Gas",
            "Elétrico"});
            this.checkedListBoxFiltrarCombustivel.Location = new System.Drawing.Point(15, 176);
            this.checkedListBoxFiltrarCombustivel.Name = "checkedListBoxFiltrarCombustivel";
            this.checkedListBoxFiltrarCombustivel.Size = new System.Drawing.Size(188, 72);
            this.checkedListBoxFiltrarCombustivel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Combustivel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Marca:";
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(17, 336);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(327, 28);
            this.buttonImprimir.TabIndex = 3;
            this.buttonImprimir.Text = "Imprimir Recibo";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carros para venda";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.buttonEliminarVenda);
            this.panel4.Controls.Add(this.buttonImprimir);
            this.panel4.Controls.Add(this.listBoxVendas);
            this.panel4.Location = new System.Drawing.Point(1048, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 443);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Vendas";
            // 
            // buttonEliminarVenda
            // 
            this.buttonEliminarVenda.Location = new System.Drawing.Point(17, 370);
            this.buttonEliminarVenda.Name = "buttonEliminarVenda";
            this.buttonEliminarVenda.Size = new System.Drawing.Size(327, 23);
            this.buttonEliminarVenda.TabIndex = 21;
            this.buttonEliminarVenda.Text = "Eliminar";
            this.buttonEliminarVenda.UseVisualStyleBackColor = true;
            this.buttonEliminarVenda.Click += new System.EventHandler(this.buttonEliminarVenda_Click);
            // 
            // listBoxVendas
            // 
            this.listBoxVendas.FormattingEnabled = true;
            this.listBoxVendas.ItemHeight = 16;
            this.listBoxVendas.Location = new System.Drawing.Point(17, 38);
            this.listBoxVendas.Name = "listBoxVendas";
            this.listBoxVendas.Size = new System.Drawing.Size(327, 292);
            this.listBoxVendas.TabIndex = 0;
            // 
            // buttonFiltrarListaClientes
            // 
            this.buttonFiltrarListaClientes.Location = new System.Drawing.Point(186, 411);
            this.buttonFiltrarListaClientes.Name = "buttonFiltrarListaClientes";
            this.buttonFiltrarListaClientes.Size = new System.Drawing.Size(90, 44);
            this.buttonFiltrarListaClientes.TabIndex = 22;
            this.buttonFiltrarListaClientes.Text = "Filtrar";
            this.buttonFiltrarListaClientes.UseVisualStyleBackColor = true;
            this.buttonFiltrarListaClientes.Click += new System.EventHandler(this.buttonFiltrarListaClientes_Click);
            // 
            // textBoxFiltrarNome
            // 
            this.textBoxFiltrarNome.Location = new System.Drawing.Point(15, 432);
            this.textBoxFiltrarNome.Name = "textBoxFiltrarNome";
            this.textBoxFiltrarNome.Size = new System.Drawing.Size(165, 22);
            this.textBoxFiltrarNome.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Introduzir Nome:";
            // 
            // textBoxFiltrarModelo
            // 
            this.textBoxFiltrarModelo.Location = new System.Drawing.Point(15, 107);
            this.textBoxFiltrarModelo.Name = "textBoxFiltrarModelo";
            this.textBoxFiltrarModelo.Size = new System.Drawing.Size(188, 22);
            this.textBoxFiltrarModelo.TabIndex = 25;
            // 
            // textBoxFiltrarMarca
            // 
            this.textBoxFiltrarMarca.Location = new System.Drawing.Point(12, 41);
            this.textBoxFiltrarMarca.Name = "textBoxFiltrarMarca";
            this.textBoxFiltrarMarca.Size = new System.Drawing.Size(191, 22);
            this.textBoxFiltrarMarca.TabIndex = 26;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1404, 463);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFiltrarNome);
            this.Controls.Add(this.buttonFiltrarListaClientes);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormVenda";
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiltrarCombustivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonVender;
        private System.Windows.Forms.ListBox listBoxCarrosVenda;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBoxVendas;
        private System.Windows.Forms.Button buttonFiltrarListaCarros;
        private System.Windows.Forms.Button buttonEditarCarroVenda;
        private System.Windows.Forms.Button buttonEliminarCarroVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEliminarVenda;
        private System.Windows.Forms.Button buttonFiltrarListaClientes;
        private System.Windows.Forms.TextBox textBoxFiltrarNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFiltrarMarca;
        private System.Windows.Forms.TextBox textBoxFiltrarModelo;
    }
}