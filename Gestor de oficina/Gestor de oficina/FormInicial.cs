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
    public partial class FormInicial : Form
    {
        private StandAutomoveisContainer myDb;
        public FormInicial()
        {
            InitializeComponent();
            myDb = new StandAutomoveisContainer();
        }
        //design e funcionalidade dos botões, parecer que foram precionados e abrir os forms
        //------------------------------------------------
        private void imageFormOficina_MouseDown(object sender, MouseEventArgs e)
        {
            imageFormOficina.BorderStyle = BorderStyle.Fixed3D;
        }

        private void imageFormOficina_MouseUp(object sender, MouseEventArgs e)
        {
            imageFormOficina.BorderStyle = BorderStyle.FixedSingle;
            FormOficina formOficina = new FormOficina();
            formOficina.ShowDialog();
        }

        private void imageFormCliente_MouseDown(object sender, MouseEventArgs e)
        {
            imageFormCliente.BorderStyle = BorderStyle.Fixed3D;
        }

        private void imageFormCliente_MouseUp(object sender, MouseEventArgs e)
        {
            imageFormCliente.BorderStyle = BorderStyle.FixedSingle;
            FormClientes formClientes = new FormClientes();
            formClientes.ShowDialog();
        }

        private void imageFormAlugar_MouseDown(object sender, MouseEventArgs e)
        {
            imageFormAlugar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void imageFormAlugar_MouseUp(object sender, MouseEventArgs e)
        {
            imageFormAlugar.BorderStyle = BorderStyle.FixedSingle;
            FormAluguer formAluguer = new FormAluguer();
            formAluguer.ShowDialog();
        }

        private void imageFormVenda_MouseDown(object sender, MouseEventArgs e)
        {
            imageFormVenda.BorderStyle = BorderStyle.Fixed3D;
        }

        private void imageFormVenda_MouseUp(object sender, MouseEventArgs e)
        {
            imageFormVenda.BorderStyle = BorderStyle.FixedSingle;
            FormVenda formVenda = new FormVenda();
            formVenda.ShowDialog();
        }

        private void imageAdicionarCarroAluguer_MouseUp(object sender, MouseEventArgs e)
        {
            imageAdicionarCarroAluguer.BorderStyle = BorderStyle.FixedSingle;
            FormAdicionarCarroAluguer formAdicionarCarroAluguer = new FormAdicionarCarroAluguer();
            formAdicionarCarroAluguer.ShowDialog();
        }

        private void imageAdicionarCarroAluguer_MouseDown(object sender, MouseEventArgs e)
        {
            imageAdicionarCarroAluguer.BorderStyle = BorderStyle.Fixed3D;
        }

        private void imageAdicionarCarroVenda_MouseDown(object sender, MouseEventArgs e)
        {
            imageAdicionarCarroVenda.BorderStyle = BorderStyle.Fixed3D;
        }

        private void imageAdicionarCarroVenda_MouseUp(object sender, MouseEventArgs e)
        {
            imageAdicionarCarroVenda.BorderStyle = BorderStyle.FixedSingle;
            FormAdicionarCarroVenda formAdicionarCarroVenda = new FormAdicionarCarroVenda();
            formAdicionarCarroVenda.ShowDialog();
        }

        private void FormInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            myDb.Dispose(); 
        }
        //------------------------------------------------
    }
}
