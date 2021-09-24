using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Entidade
{
    public class CriadorDeInfantariaLeve : CriadorDeSoldado
    {
        public CriadorDeInfantariaLeve()
        {
            _soldado = new SoldadoDeInfantariaLeve();
        }
        public override void Arma()
        {
            _soldado.EscolherArma("Ataque aéreo");
        }

        public override void Foco()
        {
            _soldado.EscolherTransporte("Helicóptero de ataque do Exército");
        }

        public override void Transporte()
        {
            _soldado.DefinirFoco("Resposta rápida aérea");
        }
    }
}
