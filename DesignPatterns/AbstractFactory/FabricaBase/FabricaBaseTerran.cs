using AbstractFactory.EnergiaBase;
using AbstractFactory.Interface;
using AbstractFactory.RevestimentoBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.FabricaBase
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base Terran criada com sucesso");

            RevestimentoBaseTerran revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();

            EnergiaBaseTerran energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}
