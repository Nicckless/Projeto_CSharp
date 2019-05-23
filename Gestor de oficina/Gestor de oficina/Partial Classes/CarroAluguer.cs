using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class CarroAluguer : Carro
    {
        public CarroAluguer(string Estado, string Matricula)
        {
            this.Estado = Estado;
            this.Matricula = Matricula;
            Aluguers = new HashSet<Aluguer>();
        }
    }
}
