using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class Parcela
    {
        public Parcela(int Valor, string Descricao, int ServicoIdServico)
        {
            this.Valor = Valor;
            this.Descricao = Descricao;
            this.ServicoIdServico = ServicoIdServico;
        }
        public override string ToString()
        {
            return Descricao + " Valor: " + Valor + "€";
        }
    }
}
