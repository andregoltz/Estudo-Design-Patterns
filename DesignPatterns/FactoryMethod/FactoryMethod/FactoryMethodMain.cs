using FactoryMethod.Interface;
using FactoryMethod.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.FactoryMethod
{
    public class FactoryMethodMain
    {
        public IPersonagem Escolher_Personagem(string personagem)
        {
            switch (personagem)
            {
                case "1":
                    return new LiuKang();
                case "2":
                    return new Subzero();
                case "3":
                    return new Scorpion();
                default:
                    return null;
            }
        }
    }
}
