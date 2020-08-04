using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    class EndGame : Exception
    {
        private static long serialVersionUID = 1L;

        public EndGame(String msg) : base(msg)
        {

        }
    }
}
