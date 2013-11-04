using System;
using DotTest;
using DotTest.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class TestTestContainer
    {
        [TestMethod]
        public void Add1BadTestCaseTest()
        {
            //var testCase = new Mock<ITest>();
            //var container = new TestSuite();
            //testCase.Setup(x => x.Execute()).Throws(new AssertException("Test"));

            //container.AddTestCase(testCase.Object);
            //var reporte = container.ExcecuteAll();

            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(reporte.ExistErrors);
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(reporte.Errors[0].Contains("ITestCaseProxy: Test"));
        }

        [TestMethod]
        public void Add4BadTestCasesTest()
        {
            //var testCase1 = new Mock<ITest>();
            //var testCase2 = new Mock<ITest>();
            //var testCase3 = new Mock<ITest>();
            //var testCase4 = new Mock<ITest>();
            //var testCase5 = new Mock<ITest>();

            //var container = new TestContainer();
            //testCase1.Setup(x => x.Execute()).Throws(new AssertException("One"));
            //testCase2.Setup(x => x.Execute()).Throws(new AssertException("Two"));
            //testCase3.Setup(x => x.Execute());
            //testCase4.Setup(x => x.Execute()).Throws(new AssertException("Four"));
            //testCase5.Setup(x => x.Execute()).Throws(new AssertException("Five"));

            //container.AddTestCase(testCase1.Object);
            //container.AddTestCase(testCase2.Object);
            //container.AddTestCase(testCase3.Object);
            //container.AddTestCase(testCase4.Object);
            //container.AddTestCase(testCase5.Object);

            //var reporte = container.ExcecuteAll();

            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(reporte.ExistErrors);
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(reporte.Errors[0].Contains("ITestCaseProxy: One"));
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(reporte.Errors[1].Contains("ITestCaseProxy: Two"));
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(reporte.Errors[2].Contains("ITestCaseProxy: Four"));
            //Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(reporte.Errors[3].Contains("ITestCaseProxy: Five"));
        }
    }
}
