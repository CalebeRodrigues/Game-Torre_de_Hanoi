using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    class Torre2 : Torres
    {
        public override void update(int position)
        {
            if (NPecas == 0)
            {
                addPeca(disco.getIDPeca());
            }
        }
    }
}
