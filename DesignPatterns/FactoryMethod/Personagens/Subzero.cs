using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Personagens
{
    public class Subzero : IPersonagem
    {
        public void escolhido()
        {
            Console.WriteLine("Subzero");
        }
    }
}
