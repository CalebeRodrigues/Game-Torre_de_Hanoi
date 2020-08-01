using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    public abstract class Disco 
    {
        private int IDPeca;
        
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

        public abstract void Mover();
         
    }
}
