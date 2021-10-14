using Composite.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Pattern
{
    public class CompositePattern : ComponenteFase
    {
        private List<ComponenteFase> fasesJogo = new List<ComponenteFase>();
        public CompositePattern(string nome):base(nome)
        {

        }
        public override void Adicionar(ComponenteFase c)
        {
            this.fasesJogo.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome);

            foreach (ComponenteFase item in this.fasesJogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase c)
        {
            this.fasesJogo.Remove(c);
        }
    }
}
