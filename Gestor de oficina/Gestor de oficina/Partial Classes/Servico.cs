using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class Servico
    {
        public Servico(DateTime DataEntrada, DateTime DataSaida, string Tipo)
        {
            this.DataEntrada = DataEntrada;
            this.DataSaida = DataSaida;
            this.Tipo = Tipo;
            this.Parcelas = new HashSet<Parcela>();
        }

        public decimal totalGastoNoStand
        {
            get
            {
                decimal totalInternoVendas = 0;
                foreach (Parcela valorParcela in Parcelas)
                {
                    totalInternoVendas += valorParcela.Valor;
                }
                return totalInternoVendas;
            }
        }

        public override string ToString()
        {
            return "Data Entrada: " + DataEntrada + " - " + Tipo + " - Data Saída: " + DataSaida + "Valor Total: " + totalGastoNoStand;
        }
    }
}
