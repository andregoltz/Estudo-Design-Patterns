using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class NuvemConcreta : NuvemMolde
    {
        private string cor_preenchimento;
        private string cor_contorno;
        public NuvemConcreta(string prenchimento, string contorno)
        {
            this.cor_preenchimento = prenchimento;
            this.cor_contorno = contorno;
        }
        public override NuvemMolde Clone()
        {
            Console.WriteLine("A nuvem clonada tem contorno " + this.cor_contorno + " e preenchimento " + this.cor_preenchimento);
            return this.MemberwiseClone() as NuvemMolde;
        }
    }
}
