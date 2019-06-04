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
        private float precoaluguer;
        private float total;
        private StandAutomoveisContainer myDB;

        public FormAluguer()
        {
            InitializeComponent();
            myDB = new StandAutomoveisContainer();

            (from carro in myDB.Carros.OfType<CarroAluguer>()
             where carro.Estado.Contains("No Stand")
             orderby carro.IdCarro
             select carro).ToList();

            carroBindingSource.DataSource = myDB.Carros.OfType<CarroAluguer>().ToList();
            dataGridViewCarrosAluguer.Update();

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

        private void LerDados()
        {
            (from carro in myDB.Carros.OfType<CarroAluguer>()
             where carro.Estado.Contains("No Stand")
             orderby carro.IdCarro
             select carro).ToList();
            listBoxClientes.DataSource = myDB.Clientes.ToList();
            carroBindingSource.DataSource = myDB.Carros.OfType<CarroAluguer>().ToList();
            dataGridViewCarrosAluguer.Update();
            listBoxAlugueres.DataSource = myDB.Aluguers.ToList();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clientselected = (Cliente)listBoxClientes.SelectedItem;
            listBoxAlugueres.DataSource = clientselected.Aluguers.ToList();
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
            Aluguer aluguerselected = (Aluguer)listBoxAlugueres.SelectedItem;

            if(aluguerselected.Valor <= 0)
            {
                total = total + Convert.ToInt32(textBoxKmfeitos.Text) * precoaluguer;
                aluguerselected.Kms = Convert.ToInt32(textBoxKmfeitos.Text);
                aluguerselected.Valor = Convert.ToInt32(total);
                aluguerselected.CarroAluguer.Estado = "No Stand";
                myDB.SaveChanges();
                textBoxKmfeitos.Text = "";
                labeltotal.Text = "0€";
                checkBoxOverdate.Checked = false;
                total = 0f;
            }
            
            LerDados();
        }

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
