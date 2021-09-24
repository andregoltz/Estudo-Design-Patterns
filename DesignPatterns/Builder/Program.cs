using Builder.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercito = new Exercito();
            CriadorDeSoldado criadorDeSoldado;
            Soldado soldado;

            //criando um soldado das Forças Especiais
            criadorDeSoldado = new CriadorForcasEspeciais();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado das Forças Especiais com as características: \nArma: {0}, \nTransporte: {1}, \nFoco: {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            Console.WriteLine();

            //criando um soldado de Infantaria Leve
            criadorDeSoldado = new CriadorDeInfantariaLeve();
            exercito.ConstruirSoldado(criadorDeSoldado);
            soldado = criadorDeSoldado.ObterSoldado();
            Console.WriteLine("Soldado de Infantaria Leve com as características: \nArma: {0}, \nTransporte: {1}, \nFoco: {2}", soldado.Arma, soldado.Transporte, soldado.Foco);

            Console.ReadKey();
        }
    }
}
