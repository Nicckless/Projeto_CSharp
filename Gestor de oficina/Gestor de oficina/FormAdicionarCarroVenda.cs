using System;
using System.Linq;
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

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxNumChassi.Text) || string.IsNullOrEmpty(comboBoxMarca.Text) || string.IsNullOrEmpty(comboBoxModelo.Text) || string.IsNullOrEmpty(comboBoxCombustivel.Text))
                return;

            var extras = listBoxExtras.Items.OfType<string>().ToArray();
            string extrasComEnters = "";

            foreach (var extra in extras)
            {
                extrasComEnters += extra + "\n";
            }
            CarroVenda novoCarroVenda = new CarroVenda
            {
                NumeroChassis = maskedTextBoxNumChassi.Text,
                Marca = comboBoxMarca.Text,
                Modelo = comboBoxModelo.Text,
                Combustivel = comboBoxCombustivel.Text,
                Extras = extrasComEnters
            };
            myDb.Carros.Add(novoCarroVenda);
            myDb.SaveChanges();

            MessageBox.Show("Carro adicionado com sucesso para venda", "Criar Venda");
        }

        private void buttonAddExtra_Click(object sender, EventArgs e)
        {
            listBoxExtras.Items.Add(textBoxExtra.Text);
            textBoxExtra.Text = "";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            listBoxExtras.Items.Remove(listBoxExtras.SelectedItem);
        }
    }
}

