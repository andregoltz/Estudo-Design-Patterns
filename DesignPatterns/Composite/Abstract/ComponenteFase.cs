﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Abstract
{
    public abstract class ComponenteFase
    {
        protected string nome;
        public ComponenteFase(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(ComponenteFase c);
        public abstract void Remover(ComponenteFase c);
        public abstract void Mostrar(int profundidade);
    }
}
