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
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }

        public void CriarBase()
        {
            Console.WriteLine("Base Protoss criada com sucesso");

            RevestimentoBaseProtoss revestimento = new RevestimentoBaseProtoss();
            revestimento.Composicao();

            EnergiaBaseProtoss energia = new EnergiaBaseProtoss();
            energia.Composicao();
        }
    }
}
