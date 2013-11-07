using DotTest.ImpResult;
using DotTest.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
//
namespace Test
{
    [TestClass]
    public class TestTestSuiteResult
    {
        [TestMethod]
        public void TestSuiteResultEmpty()
        {
            var testSuite = new Mock<ITest>();
            var result = new TestSuiteResult(testSuite.Object);

            Assert.IsTrue(result.ErrorCount() == 0);
            Assert.IsTrue(result.FailureCount() == 0);
            Assert.IsTrue(result.OkCount() == 0); 
        }

        [TestMethod]
        public void TestSuiteResultWith2TestResultOk()
        {
            var testSuite = new Mock<ITest>();

            var testresult = new Mock<ITestResult>();
            var testresult2 = new Mock<ITestResult>();
            testresult.Setup(x => x.OkCount()).Returns(1);
            testresult.Setup(x => x.ErrorCount()).Returns(0);
            testresult.Setup(x => x.FailureCount()).Returns(0);

            testresult2.Setup(x => x.OkCount()).Returns(4);
            testresult2.Setup(x => x.ErrorCount()).Returns(0);
            testresult2.Setup(x => x.FailureCount()).Returns(0);

            var result = new TestSuiteResult(testSuite.Object);
            result.AddResult(testresult.Object);
            result.AddResult(testresult2.Object);

            Assert.IsTrue(result.OkCount() == 5);
            Assert.IsTrue(result.ErrorCount() == 0);
            Assert.IsTrue(result.FailureCount() == 0);
        }

        [TestMethod]
        public void TestSuiteResultWithTestResultError()
        {
            var testSuite = new Mock<ITest>();

            var testresult = new Mock<ITestResult>();
            testresult.Setup(x => x.OkCount()).Returns(0);
            testresult.Setup(x => x.ErrorCount()).Returns(4);
            testresult.Setup(x => x.FailureCount()).Returns(0);

            var result = new TestSuiteResult(testSuite.Object);
            result.AddResult(testresult.Object);

            Assert.IsTrue(result.ErrorCount() == 4);
            Assert.IsTrue(result.FailureCount() == 0);
            Assert.IsTrue(result.OkCount() == 0);
        }

        [TestMethod]
        public void TestSuiteResultWithTestResultFailure()
        {
            var testSuite = new Mock<ITest>();

            var testresult = new Mock<ITestResult>();
            testresult.Setup(x => x.OkCount()).Returns(0);
            testresult.Setup(x => x.ErrorCount()).Returns(0);
            testresult.Setup(x => x.FailureCount()).Returns(4);

            var result = new TestSuiteResult(testSuite.Object);
            result.AddResult(testresult.Object);

            Assert.IsTrue(result.ErrorCount() == 0);
            Assert.IsTrue(result.FailureCount() == 4);
            Assert.IsTrue(result.OkCount() == 0);
        }
    }
}
