using Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Entidade
{
    public class Espada : DecoratorArmadura
    {
        string _descricao = "Espada Ultra Forte, ";
        MoldeArmadura _moldeArmadura;
        public Espada(MoldeArmadura moldeArmadura)
        {
            this._moldeArmadura = moldeArmadura;
        }
        public override string Descricao
        {
            get { return _moldeArmadura.Descricao + _descricao; }
        }
    }
}
