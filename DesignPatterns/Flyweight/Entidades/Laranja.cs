using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Entidades
{
    public class Laranja : Tartaruga
    {
        public Laranja()
        {
            this.condicao = " tartaruga carregando o casco, ";
            this.acao = "andar cansada do peso - ";
        }
        public override void Mostra(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
