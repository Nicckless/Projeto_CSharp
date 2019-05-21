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
        private string numchassi;
        private string marca;
        private string modelo;
        private string combust;
        private string[] extra;
        public FormAdicionarCarroVenda()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            numchassi = maskedTextBoxNumChassi.Text;
            marca = comboBoxMarca.Text;
            modelo = comboBoxModelo.Text;
            combust = comboBoxCombustivel.Text;

        }

        private void comboBoxnumext_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxnumext.SelectedIndex == 0)
            {
                labelextra1.Visible = false;
                comboBoxExtra1.Visible = false;
                labelextra2.Visible = false;
                comboBoxExtra2.Visible = false;
                labelextra3.Visible = false;
                comboBoxExtra3.Visible = false;
                labelextra4.Visible = false;
                comboBoxExtra4.Visible = false;
                labelextra5.Visible = false;
                comboBoxExtra5.Visible = false;
            }

            if (comboBoxnumext.SelectedIndex == 1)
            {
                labelextra1.Visible = true;
                comboBoxExtra1.Visible = true;
                labelextra2.Visible = false;
                comboBoxExtra2.Visible = false;
                labelextra3.Visible = false;
                comboBoxExtra3.Visible = false;
                labelextra4.Visible = false;
                comboBoxExtra4.Visible = false;
                labelextra5.Visible = false;
                comboBoxExtra5.Visible = false;
            }

            if (comboBoxnumext.SelectedIndex == 2)
            {
                labelextra1.Visible = true;
                comboBoxExtra1.Visible = true;
                labelextra2.Visible = true;
                comboBoxExtra2.Visible = true;
                labelextra3.Visible = false;
                comboBoxExtra3.Visible = false;
                labelextra4.Visible = false;
                comboBoxExtra4.Visible = false;
                labelextra5.Visible = false;
                comboBoxExtra5.Visible = false;
            }

            if (comboBoxnumext.SelectedIndex == 3)
            {
                labelextra1.Visible = true;
                comboBoxExtra1.Visible = true;
                labelextra2.Visible = true;
                comboBoxExtra2.Visible = true;
                labelextra3.Visible = true;
                comboBoxExtra3.Visible = true;
                labelextra4.Visible = false;
                comboBoxExtra4.Visible = false;
                labelextra5.Visible = false;
                comboBoxExtra5.Visible = false;
            }

            if (comboBoxnumext.SelectedIndex == 4)
            {
                labelextra1.Visible = true;
                comboBoxExtra1.Visible = true;
                labelextra2.Visible = true;
                comboBoxExtra2.Visible = true;
                labelextra3.Visible = true;
                comboBoxExtra3.Visible = true;
                labelextra4.Visible = true;
                comboBoxExtra4.Visible = true;
                labelextra5.Visible = false;
                comboBoxExtra5.Visible = false;
            }

            if (comboBoxnumext.SelectedIndex == 5)
            {
                labelextra1.Visible = true;
                comboBoxExtra1.Visible = true;
                labelextra2.Visible = true;
                comboBoxExtra2.Visible = true;
                labelextra3.Visible = true;
                comboBoxExtra3.Visible = true;
                labelextra4.Visible = true;
                comboBoxExtra4.Visible = true;
                labelextra5.Visible = true;
                comboBoxExtra5.Visible = true;
            }
        }
    }
}

