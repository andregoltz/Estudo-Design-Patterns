using Bridge.Entidade;
using Bridge.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            BridgePattern bridge = new BridgePattern();
            Random random = new Random();

            void Sortear()
            {
                if (random.Next(2) == 1)
                    bridge.formaSolicitada = new Forma1();
                else
                    bridge.formaSolicitada = new Forma2();

                if (random.Next(1, 3) == 1)
                    bridge.formaSolicitada.ICor = new Verde();
                else if (random.Next(1, 3) == 2)
                    bridge.formaSolicitada.ICor = new Laranja();
                else
                    bridge.formaSolicitada.ICor = new Rosa();
            }

            Console.WriteLine("Pressione ENTER para enviar uma forma");

            while (1 > 0)
            {
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.KeyChar == 13)
                    Sortear();

                Console.WriteLine();
                bridge.ExibeQualFormaEstaDescendoNaTela();
            }
        }
    }
}
