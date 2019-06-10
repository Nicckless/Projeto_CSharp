using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            Cliente clienteSelecionado = new Cliente();

            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if(formAdicionarCarroOficina.ShowDialog() == DialogResult.OK)
            {

                var carroOficina = formAdicionarCarroOficina.CarroOficina;
                clienteSelecionado.CarroOficinas.Add(carroOficina);

                listBoxCarros.SelectedItem = carroOficina;

                myDb.SaveChanges();
                LerDados();
            }
        }
        private void LerDados()
        {
            listBoxCarros.DataSource = myDb.Carros.OfType<CarroOficina>().ToList();
            listBoxClientes.DataSource = myDb.Clientes.ToList();
            listBoxParcelas.DataSource = myDb.Parcelas.ToList();
            listBoxServicos.DataSource = myDb.Servicos.ToList();
        }
        private void FormOficina_Load(object sender, EventArgs e)
        {
            listBoxClientes.SelectedItem = 0;
            listBoxCarros.SelectedItem = 0;
            listBoxServicos.SelectedItem = 0;
            listBoxParcelas.SelectedItem = 0;

            listBoxClientes.DataSource = myDb.Clientes.ToList();
            listBoxCarros.DataSource = myDb.Carros.OfType<CarroOficina>().ToList();
            listBoxServicos.DataSource = myDb.Servicos.ToList();
            listBoxParcelas.DataSource = myDb.Parcelas.ToList();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex != -1 || listBoxCarros.SelectedIndex != -1 || listBoxServicos.SelectedIndex != -1)
            {
                try
                {
                    Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                    Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
                    Parcela parcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;

                    listBoxServicos.DataSource = null;
                    listBoxParcelas.DataSource = null;

                    labelNome.Text = clienteSelecionado.Nome;
                    labelNIF.Text = clienteSelecionado.NIF.ToString();
                    labelMorada.Text = clienteSelecionado.Morada;

                    if(listBoxCarros.SelectedIndex < 0)
                    {
                        labelValorTotal.Text = "0";
                    }

                    atualizarListaCarros(clienteSelecionado);
                }
                catch (Exception)
                {

                    return;
                }

            }
        }

        private void listBoxCarros_SelectedIndexChanged(object sender, EventArgs e)
        {

                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                CarroOficina carroOficinaSelecionado = (CarroOficina)listBoxCarros.SelectedItem;


                listBoxParcelas.DataSource = null;
                listBoxServicos.DataSource = null;

                atualizarListaServicos(carroOficinaSelecionado);
        }

        private void listBoxServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1 || listBoxServicos.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroOficina carroOficinaSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            labelValorTotal.Text = servicoSelecionado.totalGastoNoStand.ToString();

            atualizarListaParcelas(servicoSelecionado);
        }

        private void listBoxParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void atualizarListaCarros(Cliente clienteSelecionado)
        {
            listBoxCarros.DataSource = clienteSelecionado.CarroOficinas.ToList();
        }

        private void atualizarListaServicos(CarroOficina carroOficinaSelecionado)
        {
            listBoxServicos.DataSource = carroOficinaSelecionado.Servicoes.ToList();
        }
        
        private void atualizarListaParcelas(Servico servicoSelecionado)
        {
            listBoxParcelas.DataSource = servicoSelecionado.Parcelas.ToList();
        }

        private void buttonCriarServico_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1)
                return;

            FormAdicionarServico formAdicionarServico = new FormAdicionarServico();

            Cliente clienteSelecionado = new Cliente();
            CarroOficina carroOficinaSelecionado = new CarroOficina();

            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            carroOficinaSelecionado = (CarroOficina)listBoxCarros.SelectedItem;

            if (formAdicionarServico.ShowDialog() == DialogResult.OK)
            {
                Servico novoServico = new Servico
                {
                    Tipo = formAdicionarServico.tipoServico,
                    DataEntrada = formAdicionarServico.dataEntrada,
                    DataSaida = formAdicionarServico.dataSaida
                };
                carroOficinaSelecionado.Servicoes.Add(novoServico);

                listBoxServicos.SelectedItem = novoServico;

                myDb.SaveChanges();
                LerDados();
            }
        }

        private void buttonCriarParcela_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1 || listBoxServicos.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = new Cliente();
            CarroOficina carroOficinaSelecionado = new CarroOficina();
            Servico servicoSelecionado = new Servico();

            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            carroOficinaSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

            if (string.IsNullOrEmpty(textBoxValorParcela.Text) || string.IsNullOrEmpty(textBoxDescricaoParcela.Text))
                return;

            int ValorParcela = 0;
            if (!int.TryParse(textBoxValorParcela.Text, out ValorParcela))
            {
                MessageBox.Show("Erro ao introduzir valor", "Valor incorreto: " + textBoxValorParcela.Text);
                return;
            }

            Parcela novaParcela = new Parcela
            {
                Valor = ValorParcela,
                Descricao = textBoxDescricaoParcela.Text
            };
            servicoSelecionado.Parcelas.Add(novaParcela);

            listBoxParcelas.SelectedItem = novaParcela;

            myDb.SaveChanges();
            LerDados();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxClientes.SelectedIndex == -1 || listBoxCarros.SelectedIndex == -1 || listBoxServicos.SelectedIndex == -1 || listBoxParcelas.SelectedIndex == -1)
                    return;


                Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
                CarroOficina carroOficinaSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
                Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;

                string[] lines = { "Dados do Cliente:\n Nome do cliente: " + clienteSelecionado.Nome +  "\n Morada: " + clienteSelecionado.Morada + "\n Contacto: " + clienteSelecionado.Contacto + "\n NIF: " + clienteSelecionado.NIF,
                "\n-------------------------------------\nDados do Automóvel: \n Numero Chassis: " + carroOficinaSelecionado.NumeroChassis + "\n\nMarca + Modelo: " + carroOficinaSelecionado.Marca + " " + carroOficinaSelecionado.Modelo + "\n Combustivel: " + carroOficinaSelecionado.Combustivel + "\n Matricula: " + carroOficinaSelecionado.Matricula + "\n Quilometros: " + carroOficinaSelecionado.Kms + " kms",
                "\n-------------------------------------\nDados do Servico: \n Data de entrada: " + servicoSelecionado.DataEntrada + "\n Data de saída: " + servicoSelecionado.DataSaida + "\n Tipo de servico: " + servicoSelecionado.Tipo + "\nValor total do Servico: " + servicoSelecionado.totalGastoNoStand + "€"};

                string docPath = @"E:\Everything\Universidade\TeSP\2_Semestre\Desenvolvimento_de_Aplicações\Projeto\Projeto DA\Projeto_CSharp\Gestor de oficina\Recibos da Oficina";

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, carroOficinaSelecionado.Matricula + ".txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }

                try
                {
                    DialogResult dialogResult = MessageBox.Show("Impressao concluida com sucesso, deseja abrir o recibo?", "Impressao Concluída", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start(docPath + "\\" + carroOficinaSelecionado.Matricula + ".txt");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    };
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possível abrir recibo", "Erro a abrir");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nao foi possível imprimir recibo", "Erro na impressao");
                return;
            }
        }
    }
}
