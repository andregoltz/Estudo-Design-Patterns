using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.Abstract;

namespace TemplateMethod.Entidades
{
    public class ModoDificil : Jogo
    {
        public override void PrimeiraFase()
        {
            Console.WriteLine("Adicionar obstaculo na pista");
        }

        public override void SegundaFase()
        {
            Console.WriteLine("Carros adversários devem correr mais rápido");
        }
    }
}
