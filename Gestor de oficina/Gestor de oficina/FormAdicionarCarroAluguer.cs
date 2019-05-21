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
    public partial class FormAdicionarCarroAluguer : Form
    {
        private string chassi;
        private string marca;
        private string modelo;
        private string combust;
        private string matricula;

        public FormAdicionarCarroAluguer()
        {
            InitializeComponent();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //adicionar na base de dados
            chassi = maskedTextBoxNumChassi.Text;
            marca = comboBoxMarca.Text;
            modelo = comboBoxModelo.Text;
            combust = comboBoxCombustivel.Text;
            matricula = maskedTextBoxMatricula.Text;
        }
    }
}
