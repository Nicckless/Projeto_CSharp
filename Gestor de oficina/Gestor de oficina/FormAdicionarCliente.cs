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
    public partial class FormAdicionarCliente : Form
    {
        private StandAutomoveisContainer myDb;
        public FormAdicionarCliente()
        {
            InitializeComponent();
            myDb = new StandAutomoveisContainer();
        }

        //Adiciona um cliente à base de dados
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente
            {
                Nome = textBoxNome.Text,
                Contacto = textBoxContacto.Text,
                Morada = textBoxMorada.Text,
                NIF = Convert.ToInt32(textBoxNIF.Text)
            };
            myDb.Clientes.Add(novoCliente);
            myDb.SaveChanges();
            Close();
        }
    }
}
