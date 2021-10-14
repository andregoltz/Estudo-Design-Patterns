using Flyweight.Entidades;
using Flyweight.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {

            FlyWeightPattern flyWeight = new FlyWeightPattern();
            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Qual tartaruga enviar para tela: azul/verde/laranja/vermelha ");

                cor = Console.ReadLine();

                tartaruga = flyWeight.GetTartaruga(cor);
                tartaruga.Mostra(cor);

                Console.WriteLine();
                Console.WriteLine("-----------------------");
            }
        }
    }
}
