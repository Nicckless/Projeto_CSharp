using System;
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

            int ValorVenda = 0;
            if (!int.TryParse(textBoxValor.Text, out ValorVenda))
            {
                MessageBox.Show("Erro ao introduzir valor", "Valor incorreto: "+ textBoxValor.Text);
                return;
            }

            Venda = new Venda { Valor = ValorVenda, Estado = comboBoxEstado.Text, Data = DateTime.Now };
            DialogResult = DialogResult.OK;
        }
    }
}
