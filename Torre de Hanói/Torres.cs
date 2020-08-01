using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    public abstract class Torres
    {
        private int IDTorre;

        public Torres()
        {

        }

        public Torres(int IDTorre)
        {
            this.IDTorre = IDTorre;
        }

        public int getIDTorre()
        {
            return IDTorre;
        }

        public abstract void update();

    }
}
