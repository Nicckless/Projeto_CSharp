using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_de_oficina
{
    public partial class FormEditarCarroVenda : Form
    {
        private StandAutomoveisContainer myDb;
        public CarroVenda carroVenda { get; set; }
        public FormEditarCarroVenda()
        {
            InitializeComponent();
            myDb = new StandAutomoveisContainer();
        }

        public void InicializarCarroVenda(CarroVenda carVenda)
        {
            bindingSource1.DataSource = carVenda;
            listBoxExtras.DataSource = carVenda.Extras.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void buttonEditarCarro_Click(object sender, EventArgs e)
        {
            CarroVenda bindingCarroVenda = GetCarroVenda();
            CarroVenda dbCarroVenda = myDb.Carros.OfType<CarroVenda>().First();
            var extras = listBoxExtras.Items.OfType<string>().ToArray();
            string extraComEnters = "";
            foreach (var extra in extras)
            {
                extraComEnters += extra + "\n";
            }


            dbCarroVenda.NumeroChassis = maskedTextBoxNumChassi.Text;
            dbCarroVenda.Marca = comboBoxMarca.Text;
            dbCarroVenda.Modelo = comboBoxModelo.Text;
            dbCarroVenda.Combustivel = comboBoxCombustivel.Text;
            dbCarroVenda.Extras = extraComEnters;
            myDb.SaveChanges();
            DialogResult = DialogResult.OK;

            MessageBox.Show("Carro Editado com sucesso", "Carro Editado");
        }

        public CarroVenda GetCarroVenda()
        {
            return bindingSource1.DataSource as CarroVenda;
        }
    }
}
