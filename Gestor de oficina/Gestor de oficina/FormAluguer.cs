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

        private void LerDadosCliente()
        {
            listBoxClientes.DataSource = myDB.Clientes.ToList();
        }
    }
}
