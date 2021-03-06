﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class CarroOficina : Carro
    {
        public CarroOficina(int Kms, string Matricula)
        {
            this.Kms = Kms;
            this.Matricula = Matricula;
            this.Servicoes = new HashSet<Servico>();
        }
        public override string ToString()
        {
            return Marca + " (" + Modelo + ") - Chassis: " + NumeroChassis + " - Combustivel: " + Combustivel;
        }
    }
}
