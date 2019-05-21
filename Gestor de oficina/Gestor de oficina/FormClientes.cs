using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestor_de_oficina
{
    public partial class FormClientes : Form
    {
        private StandAutomoveisContainer myDb;
        public FormClientes()
        {
            InitializeComponent();
            myDb = new StandAutomoveisContainer();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            SaveCustomerInfo();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
        
        private void SaveCustomerInfo()
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
            LerDados();
        }

        private void LerDados()
        {
            dataGridView1.DataSource = myDb.Clientes.ToList();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            LerDados();
            //SaveCustomerInfo();
        }
    }
}
