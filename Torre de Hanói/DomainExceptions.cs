using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torre_de_Hanói
{
    class DomainExceptions : Exception
    {
        private static long serialVersionUID = 1L;
        
        public DomainExceptions(String msg) : base(msg)
        {
            
        }
    }
}
