using System;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            listBoxVendas.DataSource = myDb.Vendas.ToList();
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            if (listBoxCliente.SelectedIndex == -1 || listBoxCarrosVenda.SelectedIndex == -1)
                return;

            FormCriarVenda formCriarVenda = new FormCriarVenda();
            Cliente clienteSelecionado = (Cliente)listBoxCliente.SelectedItem;
            CarroVenda carroVendaSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;

            if (formCriarVenda.ShowDialog() == DialogResult.OK)
            {
                var venda = formCriarVenda.Venda;

                venda.CarroVenda = carroVendaSelecionado;
                myDb.Vendas.Add(venda);
                clienteSelecionado.Vendas.Add(venda);

                listBoxCarrosVenda.ClearSelected();
                myDb.SaveChanges();
                lerDados();

                listBoxVendas.SelectedItem = venda;
            }
        }

        private void buttonEliminarCarroVenda_Click(object sender, EventArgs e)
        {
            CarroVenda carroVendaSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;

            myDb.Carros.Remove(carroVendaSelecionado);
            myDb.SaveChanges();
            lerDados();
        }

        private void buttonEliminarVenda_Click(object sender, EventArgs e)
        {
            Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;

            myDb.Vendas.Remove(vendaSelecionada);
            myDb.SaveChanges();
            lerDados();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxVendas.SelectedIndex == -1)
                    return;


                Cliente clienteSelecionado = (Cliente)listBoxCliente.SelectedItem;
                CarroVenda carroVendaSelecionado = (CarroVenda)listBoxCarrosVenda.SelectedItem;
                Venda vendaSelecionada = (Venda)listBoxVendas.SelectedItem;

                string[] lines = { "Dados do Cliente:\n Nome do cliente: " + vendaSelecionada.Cliente.Nome +  "\n Morada: " + vendaSelecionada.Cliente.Morada + "\n Contacto: " + vendaSelecionada.Cliente.Contacto + "\n NIF: " + vendaSelecionada.Cliente.NIF,
                "\n-------------------------------------\nDados do Automóvel: \n Numero Chassis: " + vendaSelecionada.CarroVenda.NumeroChassis + "\n\nMarca + Modelo: " + vendaSelecionada.CarroVenda.Marca  + " " + vendaSelecionada.CarroVenda.Modelo  + "\n Combustivel: " + vendaSelecionada.CarroVenda.Combustivel  + "\n Extras do automovel: " + vendaSelecionada.CarroVenda.Extras,
                "\n-------------------------------------\nDados da venda: \n Data de entrada: " + vendaSelecionada.Data + "\n Estado do veículo: " + vendaSelecionada.Estado + "\nValor total da venda: " + vendaSelecionada.Valor + "€"};

                string docPath = @"E:\Everything\Universidade\TeSP\2_Semestre\Desenvolvimento_de_Aplicações\Projeto\Projeto DA\Projeto_CSharp\Gestor de oficina\Recibos de Venda";

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, vendaSelecionada.CarroVenda.NumeroChassis + ".txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }

                try
                {
                    DialogResult dialogResult = MessageBox.Show("Impressao concluida com sucesso, deseja abrir o recibo?", "Impressao Concluída", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start(docPath + "\\" + vendaSelecionada.CarroVenda.NumeroChassis + ".txt");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nao foi possível abrir recibo", "Erro a abrir");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possível imprimir recibo", "Erro na impressao");
                return;
            }
        }

        private void listBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCliente.SelectedIndex < 0)
                return;

            try
            {
                Cliente clienteSelecionado = listBoxCliente.SelectedItem as Cliente;

                atualizarListaVenda(clienteSelecionado);
            }
            catch (Exception)
            {
                return;
            }

        }

        private void atualizarListaVenda(Cliente clienteSelecionado)
        {
            listBoxVendas.DataSource = clienteSelecionado.Vendas.ToList();
        }

        private void buttonEditarCarroVenda_Click(object sender, EventArgs e)
        {
            if (listBoxCarrosVenda.SelectedIndex == -1)
                return;

            FormEditarCarroVenda formEditarCarroVenda = new FormEditarCarroVenda();


            CarroVenda carroVendaSelecionado = listBoxCarrosVenda.SelectedItem as CarroVenda;


            formEditarCarroVenda.InicializarCarroVenda(carroVendaSelecionado);
            if (formEditarCarroVenda.ShowDialog() == DialogResult.OK)
            {
                ((IObjectContextAdapter)myDb).ObjectContext
                    .Refresh(System.Data.Entity.Core.Objects.RefreshMode.StoreWins, carroVendaSelecionado);
                lerDados();
            }

        }

        private void buttonFiltrarListaCarros_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFiltrarMarca.Text) && string.IsNullOrEmpty(textBoxFiltrarModelo.Text) && string.IsNullOrEmpty(checkedListBoxFiltrarCombustivel.Text))
            {
                listBoxCarrosVenda.DataSource = myDb.Carros.OfType<CarroVenda>().ToList();
                return;
            }
                listBoxCarrosVenda.DataSource = myDb.Carros.OfType<CarroVenda>().
                    Where(cv => cv.Marca.ToLower().Contains(textBoxFiltrarMarca.Text.ToLower().Trim())).
                    ToList();

        }

        private void buttonFiltrarListaClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFiltrarNome.Text))
            {
                listBoxCliente.DataSource = myDb.Clientes.ToList();
                return;
            }

            listBoxCliente.DataSource = myDb.Clientes
                .Where(c => c.Nome.ToLower().Contains(textBoxFiltrarNome.Text.ToLower().Trim()))
                .ToList();
        }
    }
}
