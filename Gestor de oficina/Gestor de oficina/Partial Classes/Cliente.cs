using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class Cliente
    {
        public Cliente(string Nome, string Morada, int NIF, string Contacto)
        {
            this.Nome = Nome;
            this.Morada = Morada;
            this.NIF = NIF;
            this.Contacto = Contacto;
            CarroOficinas = new HashSet<CarroOficina>();
            Vendas = new HashSet<Venda>();
            Aluguers = new HashSet<Aluguer>();
        }
        public override string ToString()
        {
            return Nome + " (" + IdCliente + ") - " + NIF; 
        }
    }
}
