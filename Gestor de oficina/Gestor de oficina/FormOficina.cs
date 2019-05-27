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
            Cliente clienteSelecionado = new Cliente();

            clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            if(formAdicionarCarroOficina.ShowDialog() == DialogResult.OK)
            {

                CarroOficina novoCarroOficina = new CarroOficina
                {
                    NumeroChassis = formAdicionarCarroOficina.numchassis,
                    Marca = formAdicionarCarroOficina.marca,
                    Modelo = formAdicionarCarroOficina.modelo,
                    Combustivel = formAdicionarCarroOficina.combustivel, 
                    Matricula = formAdicionarCarroOficina.matricula,
                    Kms = formAdicionarCarroOficina.kms
                };
                clienteSelecionado.CarroOficinas.Add(novoCarroOficina);

                listBoxCarros.SelectedItem = novoCarroOficina;

                myDb.SaveChanges();
                LerDados();
            }
        }
        private void LerDados()
        {
            listBoxCarros.DataSource = myDb.Carros.ToList();
            listBoxClientes.DataSource = myDb.Clientes.ToList();
            listBoxParcelas.DataSource = myDb.Parcelas.ToList();
            listBoxServicos.DataSource = myDb.Servicos.ToList();
        }
        private void FormOficina_Load(object sender, EventArgs e)
        {
            listBoxClientes.DataSource = myDb.Clientes.ToList();
            listBoxCarros.DataSource = myDb.Carros.ToList();
            listBoxServicos.DataSource = myDb.Servicos.ToList();
            listBoxParcelas.DataSource = myDb.Parcelas.ToList();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            CarroOficina carroSelecionado = (CarroOficina)listBoxCarros.SelectedItem;
            Servico servicoSelecionado = (Servico)listBoxServicos.SelectedItem;
            Parcela parcelaSelecionada = (Parcela)listBoxParcelas.SelectedItem;

            labelNome.Text = clienteSelecionado.Nome;
            labelNIF.Text = clienteSelecionado.NIF.ToString();
            labelMorada.Text = clienteSelecionado.Morada;

            atualizarListaCarros(clienteSelecionado);
        }

        private void atualizarListaCarros(Cliente clienteSelecionado)
        {
            listBoxCarros.DataSource = null;
            listBoxParcelas.DataSource = null;
            listBoxServicos.DataSource = null;
            listBoxCarros.DataSource = clienteSelecionado.CarroOficinas.ToList();
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


        }
    }
}
