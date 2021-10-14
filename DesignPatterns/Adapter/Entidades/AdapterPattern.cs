using Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Entidades
{
    public class AdapterPattern : IAcao
    {
        Aviao aviao;
        public AdapterPattern(Aviao novo_aviao)
        {
            this.aviao = novo_aviao;
        }
        public void Andar(string jogador)
        {
            this.aviao.Voar("Rodrigo");
        }

        public void Atirar()
        {
            this.aviao.SoltarMissil();
        }
    }
}
