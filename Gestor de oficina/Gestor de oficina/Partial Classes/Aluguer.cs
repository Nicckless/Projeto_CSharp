using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class Aluguer
    {
        //Fazer o tostring para poder mostrar no form aluguer
        public override string ToString()
        {
            if(Valor <= 0)
            {
                return CarroAluguer.Marca + " " + CarroAluguer.Modelo + " " + DataFim.Date.ToString("dd/MM/yyyy") + " / Por Pagar";
            }
            else
            {
                return CarroAluguer.Marca + " " + CarroAluguer.Modelo + " " + DataFim.Date.ToString("dd/MM/yyyy") + " " + Kms + "Km / " + Valor + "€" + " / Pago";
            } 
        }
    }
}
