using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    class Maior : Disco
    {

        public Maior(int ID) : base(3)
        {

        }

        public override void Mover(int position, int[] peca, int NPeca)
        {
            if(NPeca != 0)
            {
                new DomainExceptions("Impossivel mover a peça para essa posição!");
            }
        }
    }
}
