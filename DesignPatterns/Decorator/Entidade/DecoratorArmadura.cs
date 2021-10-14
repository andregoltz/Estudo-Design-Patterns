using Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entidade
{
    public class DecoratorArmadura : MoldeArmadura
    {
        string _descricao = "Decorador Abstrato da Armadura do Personagem, ";

        public override string Descricao
        {
            get { return _descricao; }
        }
    }
}
