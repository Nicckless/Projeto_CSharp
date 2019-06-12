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
    public partial class FormAdicionarCarroAluguer : Form
    {
        private StandAutomoveisContainer myDB;

        public FormAdicionarCarroAluguer()
        {
            InitializeComponent();
            myDB = new StandAutomoveisContainer();
        }

        //Criar um novo carro de aluguer e colocar todos os campos de volta a branco
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            if(maskedTextBoxNumChassi.Text != "" && maskedTextBoxMatricula.Text != "" && comboBoxMarca.Text != "" && textBoxModelo.Text != "" && comboBoxCombustivel.Text != "")
            {
                CarroAluguer carroAluguer = new CarroAluguer
                {
                    NumeroChassis = maskedTextBoxNumChassi.Text,
                    Marca = comboBoxMarca.Text,
                    Modelo = textBoxModelo.Text,
                    Combustivel = comboBoxCombustivel.Text,
                    Matricula = maskedTextBoxMatricula.Text,
                    Estado = "No Stand"
                };
                myDB.Carros.Add(carroAluguer);

                myDB.SaveChanges();

                maskedTextBoxNumChassi.Text = "";
                comboBoxMarca.Text = "";
                textBoxModelo.Text = "";
                comboBoxCombustivel.Text = "";
                maskedTextBoxMatricula.Text = "";
            }
        }
    }
}
