using Proxy.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFase proxy = new ProxyFase();

            Console.WriteLine("#### Tentando acessar a fase do jogo com o PASSWORD incorreto");
            Console.WriteLine(proxy.InformarPassword("465"));
            Console.WriteLine(proxy.Jogar());
            Console.WriteLine();

            Console.WriteLine("#### Tentando acessar a fase do jogo com o PASSWORD correto");
            Console.WriteLine(proxy.InformarPassword("123"));
            Console.WriteLine(proxy.Jogar());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
