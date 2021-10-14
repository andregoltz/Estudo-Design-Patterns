﻿using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Entidade
{
    public class Forma2 : IForma
    {
        public ICor ICor { get; set; }

        public string Descer()
        {
            return "U - " + ICor.Cor();
        }
    }
}
