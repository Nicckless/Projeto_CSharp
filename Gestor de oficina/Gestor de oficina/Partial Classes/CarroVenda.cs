﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class CarroVenda : Carro
    {
        public CarroVenda()
        {

        }
        public CarroVenda(string Extras)
        {
            this.Extras = Extras;
        }
    }
}
