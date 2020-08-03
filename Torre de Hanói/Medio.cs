using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    class Medio : Disco
    {

        public Medio(int ID) : base(2)
        {
            
        }

        public override void Mover(int position, int[] peca, int NPeca)
        {
            if(peca[NPeca] < IDPeca)
            {
                new DomainExceptions("Impossivel mover a peça para essa posição!");
            }
        }
    }
}
