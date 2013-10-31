
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
                throw new Exception("Not Equal");
            }
        }

        public static void AreNotEqual(object a, object b)
        {
            if (a.Equals(b))
            {
                throw new Exception("Equal");
            }
        }

        public static void AreSame(object a, object b)
        {
            if (!Object.ReferenceEquals(a, b))
            {
                throw new Exception("Are Not Same");
            }
        }

        public static void AreNotSame(object a, object b)
        {
            if (Object.ReferenceEquals(a, b))
            {
                throw new Exception("Are Same");
            }
        }

        public static void Fail()
        {
            throw new Exception("Fail");
        }

        public static void Fail(string message)
        {
            throw new Exception(message);
        }

        public static void IsFalse(Boolean boolean)
        {
            if (boolean)
            {
                throw new Exception("Is False");
            }
        }

        public static void IsTrue(Boolean boolean)
        {
            if (!boolean)
            {
                throw new Exception("Is True");
            }
        }

        public static void IsNull(object a)
        {
            if (a != null)
            {
                throw new Exception("Is Not Null");
            }
        }

        public static void IsNotNull(object a)
        {
            if (a == null)
            {
                throw new Exception("Is Null");
            }
        }

        public static void IsInstanceOfType(object a, Type type)
        {
            if (a.GetType() != type)
            {
                throw new Exception("Is Not Instance Of Type");
            }
        }

        public static void IsNotInstanceOfType(object a, Type type)
        {
            if (a.GetType() == type)
            {
                throw new Exception("Is Instance Of Type");
            }
        }
    
    }
}
