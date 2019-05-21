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
        private StandAutomoveisContainer myDB;
        public FormAdicionarCarroOficina()
        {
            InitializeComponent();
            myDB = new StandAutomoveisContainer();
        }

        private void buttonAdicionarCarroOficina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxNumeroChassis.Text) || string.IsNullOrEmpty(comboBoxModelo.Text) || string.IsNullOrEmpty(comboBoxMarca.Text) || string.IsNullOrEmpty(comboBoxCombustivel.Text) || string.IsNullOrEmpty(maskedTextBoxMatricula.Text) || string.IsNullOrEmpty(textBoxKMs.Text))
                return;

            CarroOficina novoCarroOficina = new CarroOficina
            {
                NumeroChassis = maskedTextBoxNumeroChassis.Text,
                Marca = comboBoxMarca.Text,
                Modelo = comboBoxModelo.Text,
                Combustivel = comboBoxCombustivel.Text,
                Matricula = maskedTextBoxMatricula.Text,
                Kms = Convert.ToInt32(textBoxKMs.Text)
            };
            myDB.Carros.Add(novoCarroOficina);

            myDB.SaveChanges();
        }
    }
}
