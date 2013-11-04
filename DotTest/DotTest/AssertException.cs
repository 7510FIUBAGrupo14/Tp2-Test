using System;

namespace DotTest
{
    public class AssertException : Exception
    {
        public AssertException(string message) : base(message) { }
    }

    public class AssertSuccess : Exception
    {
    }
}
