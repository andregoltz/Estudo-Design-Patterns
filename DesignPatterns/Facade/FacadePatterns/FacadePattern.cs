using Facade.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.FacadePatterns
{
    public class FacadePattern
    {
        private SubSistemaUm um;
        private SubSistemaDois dois;
        private SubSistemaTres tres;
        public FacadePattern()
        {
            this.um = new SubSistemaUm();
            this.dois = new SubSistemaDois();
            this.tres = new SubSistemaTres();
        }

        public void OperacaoA()
        {
            Console.WriteLine("\nOperação A --------------- ");
            this.um.Responsabilidade();
            this.dois.Resposabilidade();
        }

        public void OperacaoB()
        {
            Console.WriteLine("\nOperação B --------------- ");
            this.tres.Responsabilidade();
        }
    }
}
