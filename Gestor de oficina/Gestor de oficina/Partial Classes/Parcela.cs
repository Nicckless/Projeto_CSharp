﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_oficina
{
    public partial class Parcela
    {
        public Parcela()
        {

        }
        public Parcela(int Valor, string Descricao)
        {
            this.Valor = Valor;
            this.Descricao = Descricao;
        }
        public override string ToString()
        {
            return Descricao + " Valor: " + Valor + "€";
        }
    }
}
