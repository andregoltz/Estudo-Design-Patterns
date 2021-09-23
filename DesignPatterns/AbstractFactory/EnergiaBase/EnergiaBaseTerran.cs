using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.EnergiaBase
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base mecânica");
        }
    }
}
