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
    public partial class FormVenda : Form
    {
        private StandAutomoveisContainer myDb;
        public FormVenda()
        {
            InitializeComponent();
            myDb = new StandAutomoveisContainer();
        }

        private void listBoxCarrosVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormVenda_Load(object sender, EventArgs e)
        {

            lerDados();
        }
        private void lerDados()
        {
            listBoxCarrosVenda.DataSource = myDb.Carros.OfType<CarroVenda>().ToList();
            listBoxCliente.DataSource = myDb.Clientes.ToList();
        }
        private void inserirCarroVenda()
        {

        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            if (listBoxCliente.SelectedIndex == -1)
                return;

            FormCriarVenda formCriarVenda = new FormCriarVenda();
            Cliente clienteSelecionado = new Cliente();
            clienteSelecionado = (Cliente)listBoxCliente.SelectedItem;

        }
    }
}
