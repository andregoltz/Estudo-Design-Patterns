using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Personagens
{
    public class LiuKang : IPersonagem
    {
        public void escolhido()
        {
            Console.Write("Liu Kang");
        }
    }
}
