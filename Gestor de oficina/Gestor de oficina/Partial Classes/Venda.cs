using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class Venda
    {
        public Venda(int Valor, string Estado)
        {
            this.Valor = Valor;
            this.Estado = Estado;
            this.Data = Data;
        }
        public override string ToString()
        {
            return Data + " (" + Estado + ") - " + Valor + "€";
        }
    }
}
