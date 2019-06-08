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
        public Venda Venda { get; private set; }

        public FormCriarVenda()
        {
            InitializeComponent();
        }

        private void buttonCriarVenda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxEstado.Text) || string.IsNullOrEmpty(textBoxValor.Text))
                return;

            int valorvendar = 0;
            if (!int.TryParse(textBoxValor.Text, out valorvendar))
            {
                MessageBox.Show("Erro ao introduzir valor", "Valor incorreto: "+ textBoxValor.Text);
                return;
            }

            Venda = new Venda { Valor = valorvendar, Estado = comboBoxEstado.Text, Data = DateTime.Now };
            DialogResult = DialogResult.OK;
        }
    }
}
