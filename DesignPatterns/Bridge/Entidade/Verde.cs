using Bridge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Entidade
{
    public class Verde : ICor
    {
        public string Cor()
        {
            return "Verde";
        }
    }
}
