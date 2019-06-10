using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_oficina
{
    public partial class FormAdicionarCarroVenda : Form
    {
        private StandAutomoveisContainer myDb;
        public FormAdicionarCarroVenda()
        {
            InitializeComponent();
            myDb = new StandAutomoveisContainer();
        }

        //Adicionar um carro para venda à base de dados
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxNumChassi.Text) || string.IsNullOrEmpty(comboBoxMarca.Text) || string.IsNullOrEmpty(comboBoxModelo.Text) || string.IsNullOrEmpty(comboBoxCombustivel.Text))
                return;

            CarroVenda novoCarroVenda = new CarroVenda
            {
                NumeroChassis = maskedTextBoxNumChassi.Text,
                Marca = comboBoxMarca.Text,
                Modelo = comboBoxModelo.Text,
                Combustivel = comboBoxCombustivel.Text,
                Extras = listBoxExtras.Items.OfType<string>().ToString()
            };
            myDb.Carros.Add(novoCarroVenda);
            myDb.SaveChanges();

            MessageBox.Show("Carro adicionado com sucesso para venda", "Criar Venda");
        }

        //Adicionar extras do carro a ser criado
        private void buttonAddExtra_Click(object sender, EventArgs e)
        {
            listBoxExtras.Items.Add(textBoxExtra.Text);
            textBoxExtra.Text = "";
        }

        //Eliminar extras do carro a ser criado
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listBoxExtras.Items.Remove(listBoxExtras.SelectedItem);
        }
    }
}

