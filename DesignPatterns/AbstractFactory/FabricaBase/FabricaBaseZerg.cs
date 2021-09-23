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
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Zerg criada com sucesso");

            RevestimentoBaseZerg revestimento = new RevestimentoBaseZerg();
            revestimento.Composicao();

            EnergiaBaseZerg energia = new EnergiaBaseZerg();
            energia.Composicao();
        }
    }
}
