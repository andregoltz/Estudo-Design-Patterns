using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class SingletonPattern
    {
        private static SingletonPattern instancia = null;

        public static SingletonPattern GetInstancia
        { 
            get
            {
                if (instancia == null)
                {
                    instancia = new SingletonPattern();
                    Console.WriteLine("Bola em Jogo");
                }
                return instancia;
            } 
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
