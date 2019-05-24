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
        public string numchassis;
        public string marca;
        public string modelo;
        public string combustivel;
        public string matricula;
        public int kms;
        public FormAdicionarCarroOficina()
        {
            InitializeComponent();
        }

        private void buttonAdicionarCarroOficina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxNumeroChassis.Text) || string.IsNullOrEmpty(comboBoxModelo.Text) || string.IsNullOrEmpty(comboBoxMarca.Text) || string.IsNullOrEmpty(comboBoxCombustivel.Text) || string.IsNullOrEmpty(maskedTextBoxMatricula.Text) || string.IsNullOrEmpty(textBoxKMs.Text))
                return;

            numchassis = maskedTextBoxNumeroChassis.Text;
            marca = comboBoxMarca.Text;
            modelo = comboBoxModelo.Text;
            combustivel = comboBoxCombustivel.Text;
            matricula = maskedTextBoxMatricula.Text;
            kms = Convert.ToInt32(textBoxKMs.Text);
            DialogResult = DialogResult.OK;
        }
    }
}
