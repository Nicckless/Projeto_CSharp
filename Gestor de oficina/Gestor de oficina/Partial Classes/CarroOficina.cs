using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class CarroOficina : Carro
    {
        public override string ToString()
        {
            return Marca + " (" + Modelo + ") - Chassis: " + NumeroChassis + " - Combustivel: " + Combustivel;
        }
    }
}
