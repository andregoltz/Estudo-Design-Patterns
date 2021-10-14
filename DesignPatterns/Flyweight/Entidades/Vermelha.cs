using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Entidades
{
    public class Vermelha : Tartaruga
    {
        public Vermelha()
        {
            this.condicao = " tartaruga dentro do casco, ";
            this.acao = "rodando no chão - ";
        }
        public override void Mostra(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
