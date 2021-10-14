using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Entidades
{
    public class Verde : Tartaruga
    {
        public Verde()
        {
            this.condicao = " tartaruga em cima do casco, ";
            this.acao = "preparada para dar mortal - ";
        }
        public override void Mostra(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
