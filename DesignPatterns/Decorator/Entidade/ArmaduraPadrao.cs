using Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entidade
{
    public class ArmaduraPadrao : MoldeArmadura
    {
        string _descricao = "Proteção Simples, ";

        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
