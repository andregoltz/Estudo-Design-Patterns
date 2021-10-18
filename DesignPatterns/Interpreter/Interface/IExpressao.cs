using Interpreter.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter.Interface
{
    public interface IExpressao
    {
        void Interpretar(Contexto contexto);
    }
}
