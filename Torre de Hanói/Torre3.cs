using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    class Torre3 : Torres
    {
        private int[] gabarito = { 3, 2, 1 };

        public override void update(int position)
        {
            if(NPecas == 0)
            {
                addPeca(disco.getIDPeca());
            }
        }

        public override void scannerTorre()
        {
            if (peca.Equals(gabarito))
            {
                new EndGame("Fim de jogo!");
            }
        }
    }
}
