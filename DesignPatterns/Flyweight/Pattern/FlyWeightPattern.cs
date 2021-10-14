using Flyweight.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Pattern
{
    public class FlyWeightPattern
    {
        private Dictionary<string, Tartaruga> listaDeTartarugas = new Dictionary<string, Tartaruga>();

        public Tartaruga GetTartaruga(string cor)
        {
            Tartaruga t = null;

            if (listaDeTartarugas.ContainsKey(cor))
            {
                t = listaDeTartarugas[cor];
            }
            else
            {
                switch (cor)
                {
                    case "azul":
                        t = new Azul();
                        break;
                    case "verde":
                        t = new Verde();
                        break;
                    case "laranja":
                        t = new Laranja();
                        break;
                    case "vermelha":
                        t = new Vermelha();
                        break;
                    default:
                        break;
                }
                listaDeTartarugas.Add(cor, t);
            }
            return t;
        }
    }
}
