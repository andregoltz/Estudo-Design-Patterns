using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Entidades
{
    public class Azul : Tartaruga
    {
        public Azul()
        {
            this.condicao = " tartaruga fora do casco, ";
            this.acao = "andando normalmente - ";
        }
        public override void Mostra(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
