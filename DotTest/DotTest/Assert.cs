
using System;

namespace DotTest
{
    public static class Assert
    {
        public static void AreEqual(object a, object b)
        {
            if ( !a.Equals(b))
            {
                throw new Exception("Not Equal");
            }
        }
    }
}
