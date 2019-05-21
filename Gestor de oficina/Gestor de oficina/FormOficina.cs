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
        private StandAutomoveisContainer myDb;
        public FormOficina()
        {
            InitializeComponent();
            myDb = new StandAutomoveisContainer();
        }

        private void buttonAdicionarCarro_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
                return;

            FormAdicionarCarroOficina formAdicionarCarroOficina = new FormAdicionarCarroOficina();
            formAdicionarCarroOficina.ShowDialog();
        }

        private void FormOficina_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = myDb.Clientes.ToList<Cliente>();
        }
    }
}
