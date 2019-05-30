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
    public partial class FormAluguer : Form
    {
        private StandAutomoveisContainer myDB;

        public FormAluguer()
        {
            InitializeComponent();
            myDB = new StandAutomoveisContainer();

            //fazer aquela cena que parece SQL para os carros aluguer
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

        /*
        private void textBoxKmdepois_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKmdepois.Text != "")
            {
                textBoxKmandtes.Text = "1000";
                try
                {
                    labelMaisKms.Text = "+ " + (Convert.ToDecimal(textBoxKmdepois.Text) - Convert.ToDecimal(textBoxKmandtes.Text)).ToString() + " Km";
                }
                catch (FormatException ex)
                {
                    //em vez disto fazer um pop up
                    Console.WriteLine("Erro não é um número");
                    textBoxKmdepois.Text = "";
                }
            }
        }
        */
        private void LerDados()
        {
            listBoxClientes.DataSource = myDB.Clientes.ToList();
            dataGridViewCarrosAluguer.DataSource = myDB.Carros.OfType<CarroAluguer>().ToList();
            listBoxAlugueres.DataSource = myDB.Aluguers.ToList();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAluguer_Load(object sender, EventArgs e)
        {
            LerDados();     
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

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
            }
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            Cliente clienteselected = (Cliente)listBoxClientes.SelectedItem;

            //Usar link para pesquisar ou usar foreach
            foreach (Aluguer aluguer in clienteselected.Aluguers)
            {
                if(aluguer.Kms == 0)
                {
                    Console.WriteLine("there is a rented car");
                }
                else
                {
                    Console.WriteLine("there is no rented car");
                }
            }
        }
    }
}
