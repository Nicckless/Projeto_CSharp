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
    public partial class FormCriarVenda : Form
    {
        public int valor;
        public string estado;
        public DateTime dataVenda;
        public FormCriarVenda()
        {
            InitializeComponent();
        }

        private void buttonCriarVenda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxEstado.Text) || string.IsNullOrEmpty(textBoxValor.Text))
                return;

            valor = Convert.ToInt32(textBoxValor.Text);
            estado = comboBoxEstado.Text;
            dataVenda = DateTime.Now;
            DialogResult = DialogResult.OK;
        }
    }
}
