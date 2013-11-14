using System;

namespace DotTest
{
    /// <summary> 
    /// Exception used by assert methods to inform test status.
    /// </summary>
    
    public class AssertException : Exception
    {
        public AssertException(string message) : base(message) { }
    }

    public class AssertSuccess : Exception
    {
    }
}
