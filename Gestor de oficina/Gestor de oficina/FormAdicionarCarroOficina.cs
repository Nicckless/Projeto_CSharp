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
    public partial class FormAdicionarCarroOficina : Form
    {
        public CarroOficina CarroOficina { get; private set; }
        public FormAdicionarCarroOficina()
        {
            InitializeComponent();
        }

        //Adicionar um carro de oficina ao cliente
        private void buttonAdicionarCarroOficina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxNumeroChassis.Text) || string.IsNullOrEmpty(comboBoxModelo.Text) || string.IsNullOrEmpty(comboBoxMarca.Text) || string.IsNullOrEmpty(comboBoxCombustivel.Text) || string.IsNullOrEmpty(maskedTextBoxMatricula.Text) || string.IsNullOrEmpty(textBoxKMs.Text))
                return;

            int QuilometrosAutomovel = 0;
            if (!int.TryParse(textBoxKMs.Text, out QuilometrosAutomovel))
            {
                MessageBox.Show("Erro ao introduzir valor", "Valor incorreto: " + textBoxKMs.Text);
                return;
            }

            CarroOficina = new CarroOficina { NumeroChassis = maskedTextBoxNumeroChassis.Text, Marca = comboBoxMarca.Text, Modelo = comboBoxModelo.Text, Combustivel = comboBoxCombustivel.Text, Matricula = maskedTextBoxMatricula.Text, Kms = QuilometrosAutomovel };
            DialogResult = DialogResult.OK;
        }
    }
}
