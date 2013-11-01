using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotTest
{
    public class AssertException : Exception
    {
        public AssertException(string message) : base(message) { }

    }
}
