using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotTest;

namespace Test
{
    /// <summary> 
    /// NUnit tests to ensure code coverage
    /// </summary>
    
    [TestClass]
    public class TestAsserts
    {
        [TestMethod]
        [ExpectedException(typeof(AssertException),"Not Equal")]
        public void AreEqualStringsFail()
        {
            var a = "a";
            var b = "b";
            DotTest.Assert.AreEqual(a,b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void AreEqualStringsOk()
        {
            var a = "a";
            var b = "a";
            DotTest.Assert.AreEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Not Equal")]
        public void AreEqualObjectsFail()
        {
            var a = new { linea = "a" };
            var b = new { linea = "b" };
            DotTest.Assert.AreEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void AreEqualObjectsOk()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            DotTest.Assert.AreEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Not Equal")]
        public void AreEqualDistinctIntFail()
        {
            var a = 1;
            var b = 2;
            DotTest.Assert.AreEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void AreEqualIntOk()
        {
            var a = 1;
            var b = 1;
            DotTest.Assert.AreEqual(a, b);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Equal")]
        public void AreNotEqualStringsFail()
        {
            var a = "a";
            var b = "a";
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void AreNotEqualStringsOk()
        {
            var a = "a";
            var b = "b";
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Equal")]
        public void AreNotEqualObjectsFail()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void AreNotEqualObjectsOk()
        {
            var a = new { linea = "a" };
            var b = new { linea = "b" };
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Equal")]
        public void AreNotEqualIntFail()
        {
            var a = 1;
            var b = 1;
            DotTest.Assert.AreNotEqual(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void AreNotEqualIntOk()
        {
            var a = 1;
            var b = 2;
            DotTest.Assert.AreNotEqual(a, b);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void AreSameStringsOk()
        {
            var a = "a";
            var b = a;
            DotTest.Assert.AreSame(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Are Not Same")]
        public void AreSameStringsFail()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            DotTest.Assert.AreSame(a, b);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void AreNotSameStringsOk()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            DotTest.Assert.AreNotSame(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Are Same")]
        public void AreNotSameStringsFail()
        {
            var a = "a";
            var b = a;
            DotTest.Assert.AreNotSame(a, b);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void IsFalseOk()
        {
            DotTest.Assert.IsFalse(false);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Is False")]
        public void IsFalseFail()
        {
            DotTest.Assert.IsFalse(true);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void IsTrueOk()
        {
            DotTest.Assert.IsTrue(true);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Is True")]
        public void IsTrueFail()
        {
            DotTest.Assert.IsTrue(false);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void IsNullOk()
        {
            DotTest.Assert.IsNull(null);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Is Not Null")]
        public void IsNullFail()
        {
            DotTest.Assert.IsNull(1);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void IsNotNullOk()
        {
            DotTest.Assert.IsNotNull(1);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Is Null")]
        public void IsNotNullFail()
        {
            DotTest.Assert.IsNotNull(null);
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void IsInstanceOfTypeOk()
        {
            DotTest.Assert.IsInstanceOfType("a","a".GetType());
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Is Not Instance Of Type")]
        public void IsInstanceOfTypeFail()
        {
            DotTest.Assert.IsInstanceOfType("a", 1.GetType());
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertSuccess))]
        public void IsNotInstanceOfTypeOk()
        {
            DotTest.Assert.IsNotInstanceOfType("a", 1.GetType());
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Is Instance Of Type")]
        public void IsNotInstanceOfTypeFail()
        {
            DotTest.Assert.IsNotInstanceOfType("a", "a".GetType());
        }

        //-------------------------------//

        [TestMethod]
        [ExpectedException(typeof(AssertException), "")]
        public void FailVoid()
        {
            DotTest.Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(AssertException), "Hi")]
        public void FailWithMessage()
        {
            DotTest.Assert.Fail("Hi");
        }
    }
}
