using Facade.FacadePatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            FacadePattern facade = new FacadePattern();

            facade.OperacaoA();
            facade.OperacaoB();

            Console.ReadKey();
        }
    }
}
