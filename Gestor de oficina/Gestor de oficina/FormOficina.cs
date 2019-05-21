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
    public partial class FormOficina : Form
    {
        public FormOficina()
        {
            InitializeComponent();
        }

        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            CarroOficina novoCarro = new CarroOficina();
            
            clienteSelecionado.CarroOficinas.Add(novoCarro);

            listBoxCarros.DataSource = null;
            listBoxCarros.DataSource = clienteSelecionado.CarroOficinas;
        }
    }
}
