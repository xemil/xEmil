using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xEmilForms.Exception
{
    public class NoViewException : System.Exception
    {
        public NoViewException()
        {
        }

        public NoViewException(string message) : base(message)
        {
        }

        public NoViewException(string message, System.Exception inner) : base(message, inner)
        {
        }
    }

}
