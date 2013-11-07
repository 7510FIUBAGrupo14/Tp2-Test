using DotTest.Enum;
using DotTest.ImpResult;
using DotTest.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
//
namespace Test
{
    [TestClass]
    public class TestTestCaseResult
    {
        [TestMethod]
        public void TestCaseOk()
        {
            var testCase = new Mock<ITest>();
            var result = new TestCaseResult(testCase.Object, ResultType.Ok);

            Assert.IsTrue(result.ErrorCount() == 0);
            Assert.IsTrue(result.FailureCount() == 0);
            Assert.IsTrue(result.OkCount() == 1);
        }

        [TestMethod]
        public void TestCaseError()
        {
            var testCase = new Mock<ITest>();
            var result = new TestCaseResult(testCase.Object, ResultType.Error);

            Assert.IsTrue(result.ErrorCount() == 1);
            Assert.IsTrue(result.FailureCount() == 0);
            Assert.IsTrue(result.OkCount() == 0);
        }

        [TestMethod]
        public void TestCaseFailure()
        {
            var testCase = new Mock<ITest>();
            var result = new TestCaseResult(testCase.Object, ResultType.Fail);

            Assert.IsTrue(result.ErrorCount() == 0);
            Assert.IsTrue(result.FailureCount() == 1);
            Assert.IsTrue(result.OkCount() == 0); 
        }
    }
}
