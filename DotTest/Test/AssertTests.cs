using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    /// <summary> 
    /// NUnit tests to ensure code coverage
    /// </summary>
    
    [TestClass]
    public class AssertTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception),"Not Equal")]
        public void AreEqualStringsFail()
        {
            var a = "a";
            var b = "b";
            DotTest.Assert.AreEqual(a,b);
        }

        [TestMethod]
        public void AreEqualStringsOk()
        {
            var a = "a";
            var b = "a";
            DotTest.Assert.AreEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Not Equal")]
        public void AreEqualObjectsFail()
        {
            var a = new { linea = "a" };
            var b = new { linea = "b" };
            DotTest.Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void AreEqualObjectsOk()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            DotTest.Assert.AreEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Not Equal")]
        public void AreEqualDistinctIntFail()
        {
            var a = 1;
            var b = 2;
            DotTest.Assert.AreEqual(a, b);
        }

        [TestMethod]
        public void AreEqualIntOk()
        {
            var a = 1;
            var b = 1;
            DotTest.Assert.AreEqual(a, b);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(Exception), "Equal")]
        public void AreNotEqualStringsFail()
        {
            var a = "a";
            var b = "a";
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void AreNotEqualStringsOk()
        {
            var a = "a";
            var b = "b";
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Equal")]
        public void AreNotEqualObjectsFail()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void AreNotEqualObjectsOk()
        {
            var a = new { linea = "a" };
            var b = new { linea = "b" };
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Equal")]
        public void AreNotEqualIntFail()
        {
            var a = 1;
            var b = 1;
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        public void AreNotEqualIntOk()
        {
            var a = 1;
            var b = 2;
            DotTest.Assert.AreNotEqual(a, b);
        }

        //-------------------------------//

        [TestMethod]
        public void AreSameStringsOk()
        {
            var a = "a";
            var b = a;
            DotTest.Assert.AreSame(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Are Not Same")]
        public void AreSameStringsFail()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            DotTest.Assert.AreSame(a, b);
        }

        //-------------------------------//

        [TestMethod]
        public void AreNotSameStringsOk()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            DotTest.Assert.AreNotSame(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Are Same")]
        public void AreNotSameStringsFail()
        {
            var a = "a";
            var b = a;
            DotTest.Assert.AreNotSame(a, b);
        }

        //-------------------------------//

        [TestMethod]
        public void IsFalseOk()
        {
            DotTest.Assert.IsFalse(false);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Is False")]
        public void IsFalseFail()
        {
            DotTest.Assert.IsFalse(true);
        }

        //-------------------------------//

        [TestMethod]
        public void IsTrueOk()
        {
            DotTest.Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Is True")]
        public void IsTrueFail()
        {
            DotTest.Assert.IsTrue(false);
        }

        //-------------------------------//

        [TestMethod]
        public void IsNullOk()
        {
            DotTest.Assert.IsNull(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Is Not Null")]
        public void IsNullFail()
        {
            DotTest.Assert.IsNull(1);
        }

        //-------------------------------//

        [TestMethod]
        public void IsNotNullOk()
        {
            DotTest.Assert.IsNotNull(1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Is Null")]
        public void IsNotNullFail()
        {
            DotTest.Assert.IsNotNull(null);
        }

        //-------------------------------//

        [TestMethod]
        public void IsInstanceOfTypeOk()
        {
            DotTest.Assert.IsInstanceOfType("a","a".GetType());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Is Not Instance Of Type")]
        public void IsInstanceOfTypeFail()
        {
            DotTest.Assert.IsInstanceOfType("a", 1.GetType());
        }

        //-------------------------------//

        [TestMethod]
        public void IsNotInstanceOfTypeOk()
        {
            DotTest.Assert.IsNotInstanceOfType("a", 1.GetType());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Is Instance Of Type")]
        public void IsNotInstanceOfTypeFail()
        {
            DotTest.Assert.IsNotInstanceOfType("a", "a".GetType());
        }
    }
}
