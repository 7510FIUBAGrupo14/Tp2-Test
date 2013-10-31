
using System;

namespace DotTest
{
    /// <summary> 
    /// List of Assert Methods provided for User usage on customer test cases development. 
    /// </summary>
    
    public static class Assert
    {
        public static void AreEqual(object a, object b)
        {
            if ( !a.Equals(b))
            {
                throw new AssertException("Not Equal");
            }
        }

        public static void AreNotEqual(object a, object b)
        {
            if (a.Equals(b))
            {
                throw new AssertException("Equal");
            }
        }

        public static void AreSame(object a, object b)
        {
            if (!Object.ReferenceEquals(a, b))
            {
                throw new AssertException("Are Not Same");
            }
        }

        public static void AreNotSame(object a, object b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                throw new AssertException("Are Same");
            }
        }

        public static void Fail()
        {
            throw new AssertException("Fail");
        }

        public static void Fail(string message)
        {
            throw new AssertException(message);
        }

        public static void IsFalse(Boolean boolean)
        {
            if (boolean)
            {
                throw new AssertException("Is False");
            }
        }

        public static void IsTrue(Boolean boolean)
        {
            if (!boolean)
            {
                throw new AssertException("Is True");
            }
        }

        public static void IsNull(object a)
        {
            if (a != null)
            {
                throw new AssertException("Is Not Null");
            }
        }

        public static void IsNotNull(object a)
        {
            if (a == null)
            {
                throw new AssertException("Is Null");
            }
        }

        public static void IsInstanceOfType(object a, Type type)
        {
            if (a.GetType() != type)
            {
                throw new AssertException("Is Not Instance Of Type");
            }
        }

        public static void IsNotInstanceOfType(object a, Type type)
        {
            if (a.GetType() == type)
            {
                throw new AssertException("Is Instance Of Type");
            }
        }
    
    }
}
