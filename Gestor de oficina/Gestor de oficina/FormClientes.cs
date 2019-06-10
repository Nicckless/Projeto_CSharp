using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_de_oficina
{
    public partial class FormClientes : Form
    {
        private StandAutomoveisContainer myDb;
        public FormClientes()
        {
            InitializeComponent();
            myDb = new StandAutomoveisContainer();

            (from cliente in myDb.Clientes
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = myDb.Clientes.Local.ToBindingList();
            bindingNavigator1.CountItem.Text = myDb.Clientes.Local.Count().ToString();
        }

        //Abre um form para adicionar clientes á base de dados
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            FormAdicionarCliente formAdicionarCliente = new FormAdicionarCliente();
            formAdicionarCliente.ShowDialog();
            LerDados();
        }

        //Dá reload dos dados da base de dados para o Data Grid dos clientes e para o Navigator
        private void LerDados()
        {
            dataGridView1.DataSource = myDb.Clientes.ToList();
            clienteBindingSource.DataSource = myDb.Clientes.ToList();
        }


        private void FormClientes_Load(object sender, EventArgs e)
        {
            LerDados();
        }

        //Elimina clientes da base de dados
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            myDb.SaveChanges();
            LerDados();
        }

        //Fazer alterações nos dados da base de dados
        private void toolStripLabelGuardarAlt_Click(object sender, EventArgs e)
        {
            Cliente clientselected = (Cliente)dataGridView1.CurrentRow.DataBoundItem;
            myDb.Clientes.Attach(clientselected);
            clientselected.Nome = textBoxNome.Text;
            clientselected.Contacto = textBoxContacto.Text;
            clientselected.Morada = textBoxMorada.Text;
            clientselected.NIF = Convert.ToInt32(textBoxNIF.Text);
            myDb.SaveChanges();
            LerDados();
        }


        //Filtra os clientes por nome
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxfiltar.Text.Length > 0)
            {
                bindingNavigator1.AddNewItem.Enabled = false;

                myDb.Dispose();
                myDb = new StandAutomoveisContainer();

                (from cliente in myDb.Clientes
                 where cliente.Nome.ToUpper().StartsWith(textBoxfiltar.Text.ToUpper())
                 orderby cliente.Nome
                 select cliente).ToList();

                dataGridView1.DataSource = myDb.Clientes.Local.ToBindingList();
            }
            else
            {
                bindingNavigator1.AddNewItem.Enabled = true;

                myDb.Dispose();
                myDb = new StandAutomoveisContainer();

                (from cliente in myDb.Clientes
                 orderby cliente.Nome
                 select cliente).Load();

                dataGridView1.DataSource = myDb.Clientes.Local.ToBindingList();
            }
        }
    }
}

