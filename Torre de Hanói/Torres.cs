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

        public Torres(Torres torres, int IDTorre, Disco disco)
        {
            this.IDTorre = IDTorre;
            this.disco = disco;
        }

        public int getIDTorre()
        {
            return IDTorre;
        }

        public void addPeca(int peca)
        {
            try
            {
                disco.Mover(IDTorre, this.peca, NPecas);
                if (NPecas < 3)
                {
                    this.peca[NPecas] = peca;
                    NPecas++;
                }
            }
            catch(DomainExceptions e)
            {
                new DomainExceptions(e.ToString());
            }
        }

        public void removePeca(int peca)
        {
            int n = 0;

            for(int i = 0; i < 3; i++)
            {
                if(this.peca[i] == peca)
                {
                    n = i;
                }
            }

            this.peca[n] = 0;
            NPecas--;
        }

        public abstract void update(int position);
        public virtual void scannerTorre(){}

    }
}
