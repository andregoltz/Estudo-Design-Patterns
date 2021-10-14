using Adapter.Entidades;
using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem rodrigo = new Personagem();
            Aviao aviaoDeBatalha = new Aviao();

            IAcao adaptador = new AdapterPattern(aviaoDeBatalha);

            Console.WriteLine("--- CAMINHANDO ---");
            rodrigo.Andar("Rodrigo");
            rodrigo.Atirar();

            Console.WriteLine();

            Console.WriteLine("--- PEGOU UM AVIÃO NO JOGO ---");
            adaptador.Andar("Rodrigo");
            adaptador.Atirar();

            Console.ReadKey();
        }
    }
}
