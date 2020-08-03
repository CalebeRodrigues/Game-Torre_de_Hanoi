using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    public abstract class Disco 
    {
        protected int IDPeca;
        protected int Position;
        
        public Disco()
        {

        }

        public Disco(int IDPeca)
        {
            this.IDPeca = IDPeca;
        }

        public int getIDPeca()
        {
            return IDPeca;
        }

        public abstract void Mover(int position, int[] peca, int NPeca);
    }
}
