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
    public partial class FormAdicionarServico : Form
    {
        public string tipoServico;
        public DateTime dataEntrada;
        public DateTime dataSaida;
        public FormAdicionarServico()
        {
            InitializeComponent();
        }

        //Adicionar um serviço a um carro de oficina de um cliente
        private void buttonAdivionarServico_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTipoServico.Text))
                return;

            tipoServico = textBoxTipoServico.Text;
            dataEntrada = DateTime.Now;
            dataSaida = dateTimePickerDataSaida.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
