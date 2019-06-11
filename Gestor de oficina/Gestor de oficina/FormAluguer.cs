using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gestor_de_oficina
{
    public partial class FormAluguer : Form
    {
        private float precoaluguer;
        private float total;
        private StandAutomoveisContainer myDB;

        public FormAluguer()
        {
            InitializeComponent();
            myDB = new StandAutomoveisContainer();

            precoaluguer = 0.34f;
            total = 0f;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value >= DateTime.Now)
            {
                labelTotaldias.Text = Math.Round((dateTimePicker2.Value - dateTimePicker1.Value).TotalDays) + " dias";
            }
            else
                dateTimePicker2.Value = DateTime.Now;
        }

        //Dá reload aos dados dos clientes e filtrar os carros de aluguer caso eles não estejam alugados  
        private void LerDados()
        {
            (from carro in myDB.Carros.OfType<CarroAluguer>()
             where carro.Estado.Contains("No Stand")
             orderby carro.IdCarro
             select carro).ToList();

            listBoxClientes.DataSource = myDB.Clientes.ToList();
            carroAluguerBindingSource.DataSource = myDB.Carros.OfType<CarroAluguer>().ToList();
            dataGridViewCarrosAluguer.Update();
        }

        //Ao selecionar um cliente dá reload à aos dados da list box dos alugueres com os dados dos alugueres daquele cliente
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clientselected = (Cliente)listBoxClientes.SelectedItem;
            listBoxAlugueres.DataSource = clientselected.Aluguers.ToList();
        }

        private void FormAluguer_Load(object sender, EventArgs e)
        {
            LerDados();     
        }

        //Ao mudar do valor do date time picker(date time picker com a data de hoje) este muda para a data de hoje 
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        //Criar um aluguer para o cliente selecionado e põe o carro selecionado em estado aluguer
        private void buttonAlugar_Click(object sender, EventArgs e)
        {
            CarroAluguer carroAluguer = (CarroAluguer)dataGridViewCarrosAluguer.CurrentRow.DataBoundItem;
            Cliente clienteselected = (Cliente)listBoxClientes.SelectedItem;

            Aluguer aluguer = new Aluguer
            {
                DataInicio = dateTimePicker1.Value,
                DataFim = dateTimePicker2.Value,
                ClienteIdCliente = clienteselected.IdCliente,
                Cliente = clienteselected,
                CarroAluguer = carroAluguer
            };
            myDB.Aluguers.Add(aluguer);

            carroAluguer.Estado = "Alugado";

            myDB.SaveChanges();


            if (MessageBox.Show("Aluguer Criado") == DialogResult.OK)
            {
                LerDados();
                listBoxAlugueres.DataSource = clienteselected.Aluguers.ToList();
            }
        }

        //Entraga do carro alugado, calculo do preço a pagar e emissão da fatura 
        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
            Aluguer aluguerselected = (Aluguer)listBoxAlugueres.SelectedItem;

            if(aluguerselected.Valor <= 0)
            {
                total = total + Convert.ToInt32(textBoxKmfeitos.Text) * precoaluguer;
                aluguerselected.Kms = Convert.ToInt32(textBoxKmfeitos.Text);
                aluguerselected.Valor = Convert.ToInt32(total);
                aluguerselected.CarroAluguer.Estado = "No Stand";
                myDB.SaveChanges();

                if(checkBoxOverdate.Checked == true)
                {
                    string[] lines = { "Dados do Cliente:\n Nome do cliente: " + clienteSelecionado.Nome +  "\n Morada: " + clienteSelecionado.Morada + "\n Contacto: " + clienteSelecionado.Contacto + "\n NIF: " + clienteSelecionado.NIF,
                                        "\n-------------------------------------\nDados do Automóvel: \n Numero Chassis: " + aluguerselected.CarroAluguer.NumeroChassis + "\n\nMarca + Modelo: " + aluguerselected.CarroAluguer.Marca + " " + aluguerselected.CarroAluguer.Modelo + "\n Combustivel: " + aluguerselected.CarroAluguer.Combustivel + "\n Matricula: " + aluguerselected.CarroAluguer.Matricula,
                                        "\n-------------------------------------\nDados do Aluguer: \n Data de inicio de aluguer: " + aluguerselected.DataInicio + "\n Data de termino de aluguer: " + aluguerselected.DataFim + "\n Quilometros feitos: " + aluguerselected.Kms +"\n Carro entregue a tempo: Não" + "\nValor total do aluguer: " + aluguerselected.Valor + "€"};

                    string docPath = @"C:\Users\Tiago Antunes\Documents\GitHub\Projeto_CSharp\Gestor de oficina\Recibos de Aluguer";

                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, clienteSelecionado.Nome + ".txt")))
                    {
                        foreach (string line in lines)
                            outputFile.WriteLine(line);
                    }
                }
                else
                {
                    string[] lines = { "Dados do Cliente:\n Nome do cliente: " + clienteSelecionado.Nome +  "\n Morada: " + clienteSelecionado.Morada + "\n Contacto: " + clienteSelecionado.Contacto + "\n NIF: " + clienteSelecionado.NIF,
                                        "\n-------------------------------------\nDados do Automóvel: \n Numero Chassis: " + aluguerselected.CarroAluguer.NumeroChassis + "\n\nMarca + Modelo: " + aluguerselected.CarroAluguer.Marca + " " + aluguerselected.CarroAluguer.Modelo + "\n Combustivel: " + aluguerselected.CarroAluguer.Combustivel + "\n Matricula: " + aluguerselected.CarroAluguer.Matricula,
                                        "\n-------------------------------------\nDados do Aluguer: \n Data de inicio de aluguer: " + aluguerselected.DataInicio + "\n Data de termino de aluguer: " + aluguerselected.DataFim + "\n Quilometros feitos: " + aluguerselected.Kms  + "\n Carro entregue a tempo: Sim" +  "\nValor total do aluguer: " + aluguerselected.Valor + "€"};

                    string docPath = @"C:\Users\Tiago Antunes\Documents\GitHub\Projeto_CSharp\Gestor de oficina\Recibos de Aluguer";

                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, clienteSelecionado.Nome + ".txt")))
                    {
                        foreach (string line in lines)
                            outputFile.WriteLine(line);
                    }
                }

                if (MessageBox.Show("Carro devolvido e Fatura emitida") == DialogResult.OK)
                {
                    listBoxAlugueres.DataSource = clienteSelecionado.Aluguers.ToList();
                }

                textBoxKmfeitos.Text = "";
                labeltotal.Text = "0€";
                checkBoxOverdate.Checked = false;
                total = 0f;

                LerDados();
            }
        }

        //mudar de aluguer selecionado e verificação se o carro foi entregue a tempo
        private void listBoxAlugueres_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluguer aluguerselected = (Aluguer)listBoxAlugueres.SelectedItem;
            if(aluguerselected.Valor <= 0)
            {
                if (aluguerselected.DataFim < DateTime.Now)
                    checkBoxOverdate.Checked = true;

                if (checkBoxOverdate.Checked == true)
                    total = total + 50;
            }
        }

        //calculo do preço a pagar pelo aluguer
        private void textBoxKmfeitos_TextChanged(object sender, EventArgs e)
        {
            Aluguer aluguerselected = (Aluguer)listBoxAlugueres.SelectedItem;
            if (aluguerselected.Valor <= 0)
            {
                if (textBoxKmfeitos.Text.Length > 0)
                {
                    labeltotal.Text = (total + Convert.ToInt32(textBoxKmfeitos.Text) * precoaluguer).ToString() + "€";
                }
                else
                {
                    labeltotal.Text = "0€";
                }
            }
        }
    }
}
