﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class Cliente
    {

        public override string ToString()
        {
            return Nome + " (" + IdCliente + ") - " + NIF + " Total Carros: " + CarroOficinas.Count;
        }
    }
}
