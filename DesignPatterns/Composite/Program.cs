using Composite.Entidade;
using Composite.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositePattern mapa = new CompositePattern("MAPA DAS CAVERNAS");

            CompositePattern caverna1 = new CompositePattern("Caverna 1");
            caverna1.Adicionar(new FaseJogo("Sub Fase 1"));
            caverna1.Adicionar(new FaseJogo("Sub Fase 2"));
            caverna1.Adicionar(new FaseJogo("Sub Fase 3"));

            CompositePattern caverna2 = new CompositePattern("Caverna 2");
            caverna2.Adicionar(new FaseJogo("Sub Fase 4"));
            caverna2.Adicionar(new FaseJogo("Sub Fase 5"));

            CompositePattern portaSecreta = new CompositePattern("Porta Secreta");
            portaSecreta.Adicionar(new FaseJogo("Sub Fase Secreta X"));

            mapa.Adicionar(caverna1);
            mapa.Adicionar(caverna2);
            caverna2.Adicionar(portaSecreta);

            mapa.Mostrar(1);

            Console.ReadKey();
        }
    }
}
