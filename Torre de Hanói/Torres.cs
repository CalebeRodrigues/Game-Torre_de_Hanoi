using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    public abstract class Torres
    {
        protected int IDTorre;
        protected int NPecas = 0;
        protected int[] peca = new int[3];
        protected Disco disco;


        public Torres()
        {

        }

        public Torres(int IDTorre, Disco disco)
        {
            this.IDTorre = IDTorre;
            this.disco = disco;
        }

        public int getIDTorre()
        {
            return IDTorre;
        }

        public void setPeca(int peca)
        {
            if (NPecas < 3)
            {
                this.peca[NPecas] = peca;
                NPecas++;
            }
        }

        public abstract void update(int position);

    }
}
