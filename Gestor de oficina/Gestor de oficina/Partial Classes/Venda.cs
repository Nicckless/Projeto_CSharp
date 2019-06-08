using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class Venda
    {
        public Venda()
        {
            this.Data = Data;
            this.Valor = Valor;
            this.Estado = Estado;
        }
        public override string ToString()
        {
            return Data + " (" + Estado + ") - " + Valor + "€";
        }
    }
}
