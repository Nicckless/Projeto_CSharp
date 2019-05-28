using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

            (from cliente in myDb.Clientes
             orderby cliente.Nome
             select cliente).Load();

            clienteBindingSource.DataSource = myDb.Clientes.Local.ToBindingList();

            bindingNavigator1.CountItem.Text = myDb.Clientes.Local.Count().ToString();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            FormAdicionarCliente formAdicionarCliente = new FormAdicionarCliente();
            formAdicionarCliente.ShowDialog();
            LerDados();
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
            dataGridViewClientes.DataSource = myDb.Clientes.ToList();
            clienteBindingSource.DataSource = myDb.Clientes.ToList();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            LerDados();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Cliente clientselected = (Cliente)listBoxClientes.SelectedItem;
            //Cliente clientselected = (Cliente)dataGridViewClientes.SelectedRows.Cast<Cliente>();
            //Console.WriteLine(clientselected.Nome);
            //myDb.Clientes.Remove(clientselected);
            //myDb.SaveChanges();
            for(int i = 0;i < dataGridViewClientes.SelectedRows.Count; i++)
            {
                myDb.Clientes.Remove(dataGridViewClientes.SelectedRows[i].DataBoundItem as Cliente);
                clienteBindingSource.RemoveAt(dataGridViewClientes.SelectedRows[i].Index);
            }
            //LerDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxfiltar.Text.Length > 0)
            {
                bindingNavigator1.AddNewItem.Enabled = false;

                myDb.Dispose();
                myDb = new StandAutomoveisContainer();

                (from cliente in myDb.Clientes
                 where cliente.Nome.ToUpper().Contains(textBoxfiltar.Text.ToUpper())
                 orderby cliente.Nome
                 select cliente).ToList();

                dataGridViewClientes.DataSource = myDb.Clientes.Local.ToBindingList();
            }
            else
            {
                bindingNavigator1.AddNewItem.Enabled = true;

                myDb.Dispose();
                myDb = new StandAutomoveisContainer();

                (from cliente in myDb.Clientes
                 orderby cliente.Nome
                 select cliente).Load();

                dataGridViewClientes.DataSource = myDb.Clientes.Local.ToBindingList();
            }
        }

        private void toolStripLabelGuardarAlt_Click(object sender, EventArgs e)
        {
            /*
            Cliente clientselected = (Cliente)listBoxClientes.SelectedItem;
            myDb.Clientes.Attach(clientselected);
            clientselected.Nome = textBoxNome.Text;
            clientselected.Contacto = textBoxContacto.Text;
            clientselected.Morada = textBoxMorada.Text;
            clientselected.NIF = Convert.ToInt32(textBoxNIF.Text);
            myDb.SaveChanges();
            LerDados();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteselected = (Cliente)listBoxClientes.SelectedItem;
            textBoxNome.Text = clienteselected.Nome;
            textBoxMorada.Text = clienteselected.Morada;
            textBoxContacto.Text = clienteselected.Contacto;
            textBoxNIF.Text = clienteselected.NIF.ToString();
            */
        }
    }
}
