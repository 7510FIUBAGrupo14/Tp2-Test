using System.Collections.Generic;
using System.Linq;
using DotTest.ImpTest;
using DotTest.Interface;

namespace DotTest.ImpResult
{
    public class TestSuiteResult : ITestResult
    {
        private List<ITestResult> _testsResult;
        private ITest _test;

        public TestSuiteResult(ITest test)
        {
            _test = test;
            _testsResult = new List<ITestResult>();
        }

        public void AddTestResult(ITestResult testResult)
        {
            _testsResult.Add(testResult);
        }

        public string Print()
        {
            var retorno = "";

            if (_testsResult.Any(x => x.GetType() == typeof(TestCaseResult))) retorno = "\n" + _test.FullName + "\n---------------\n";
            retorno += _testsResult.Aggregate("", (current, testResult) => current + testResult.Print());
            return retorno;
        }

        public void AddResult(ITestResult testResult)
        {
            _testsResult.Add(testResult);
        }
    }
}
