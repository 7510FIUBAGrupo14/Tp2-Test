
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
            if (a == null && b == null) throw new AssertSuccess(); 
            if (!a.Equals(b))
            {
                throw new AssertException("Not Equal");
            }
            throw new AssertSuccess();
        }

        public static void AreNotEqual(object a, object b)
        {
            if ((a == null && b == null) || a.Equals(b))
            {
                throw new AssertException("Equal");
            }
            throw new AssertSuccess();
        }

        public static void AreSame(object a, object b)
        {
            if (!Object.ReferenceEquals(a, b))
            {
                throw new AssertException("Are Not Same");
            }
            throw new AssertSuccess();
        }

        public static void AreNotSame(object a, object b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                throw new AssertException("Are Same");
            }
            throw new AssertSuccess();
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
            throw new AssertSuccess();
        }

        public static void IsTrue(Boolean boolean)
        {
            if (!boolean)
            {
                throw new AssertException("Is True");
            }
            throw new AssertSuccess();
        }

        public static void IsNull(object a)
        {
            if (a != null)
            {
                throw new AssertException("Is Not Null");
            }
            throw new AssertSuccess();
        }

        public static void IsNotNull(object a)
        {
            if (a == null)
            {
                throw new AssertException("Is Null");
            }
            throw new AssertSuccess();
        }

        public static void IsInstanceOfType(object a, Type type)
        {
            if (a.GetType() != type)
            {
                throw new AssertException("Is Not Instance Of Type");
            }
            throw new AssertSuccess();
        }

        public static void IsNotInstanceOfType(object a, Type type)
        {
            if (a.GetType() == type)
            {
                throw new AssertException("Is Instance Of Type");
            }
            throw new AssertSuccess();
        }
    
    }
}
