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

        //Executar a função LerDados()
        private void FormVenda_Load(object sender, EventArgs e)
        {
            lerDados();
        }

        //Fazer Reload aos dados das list boxes dos carros venda, clientes e vendas
        private void lerDados()
        {
            listBoxCarrosVenda.DataSource = myDb.Carros.OfType<CarroVenda>().ToList();
            listBoxCliente.DataSource = myDb.Clientes.ToList();
            listBoxVendas.DataSource = myDb.Vendas.ToList();
        }

        private void inserirCarroVenda()
        {

        }


        //Criar uma venda para o cliente selecionado
        private void buttonVender_Click(object sender, EventArgs e)
        {
            if (listBoxCliente.SelectedIndex == -1)
                return;

            FormCriarVenda formCriarVenda = new FormCriarVenda();
            Cliente clienteSelecionado = (Cliente)listBoxCliente.SelectedItem;
            CarroVenda carroVendaSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;

            if (formCriarVenda.ShowDialog() == DialogResult.OK)
            {
                var venda = formCriarVenda.Venda;
                myDb.Vendas.Add(venda);
                clienteSelecionado.Vendas.Add(venda);

                myDb.SaveChanges();
                lerDados();

                listBoxVendas.SelectedItem = venda;
            }
        }
    }
}
