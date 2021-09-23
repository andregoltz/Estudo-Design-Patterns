using FactoryMethod.FactoryMethod;
using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do
            {
                Console.Clear();
                FactoryMethodMain fm = new FactoryMethodMain();
                Console.WriteLine("      *--------------------------*");
                Console.WriteLine("       Bem-vindo ao Mortal Kombat");
                Console.WriteLine("      *--------------------------*");
                Console.WriteLine();

                Console.WriteLine("Liu Kang = 1 | Subzero = 2 | Scorpion = 3");
                Console.WriteLine();

                Console.Write("Escolha seu Personagem: ");
                string escolha = Console.ReadLine();

                IPersonagem personagem = fm.Escolher_Personagem(escolha);

                Console.WriteLine();
                Console.WriteLine("Você vai jogar com ");
                personagem.escolhido();

                Console.WriteLine();
                Console.WriteLine("Deseja escolher outro personagem? [S / N]");
                opcao = Console.ReadLine().ToLower();
            } while (opcao == "s");

        }
    }
}
