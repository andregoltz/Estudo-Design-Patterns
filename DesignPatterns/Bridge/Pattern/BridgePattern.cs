using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Pattern
{
    public class BridgePattern
    {
        public IForma formaSolicitada { get; set; }

        public void ExibeQualFormaEstaDescendoNaTela()
        {
            Console.WriteLine(formaSolicitada.Descer());
        }
    }
}
