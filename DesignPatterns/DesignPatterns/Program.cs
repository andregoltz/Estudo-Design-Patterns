using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonPattern jogador_1 = SingletonPattern.GetInstancia;
            jogador_1.Mensagem("Jogador 1: A bola está comigo no meio do campo.");

            SingletonPattern jogador_2 = SingletonPattern.GetInstancia;
            jogador_2.Mensagem("Jogador 2: recebeu a bola.");

            SingletonPattern jogador_3 = SingletonPattern.GetInstancia;
            jogador_3.Mensagem("Jogador 3: recebeu o lançamento na linha de fundo.");

            Console.ReadKey();
        }
    }
}
