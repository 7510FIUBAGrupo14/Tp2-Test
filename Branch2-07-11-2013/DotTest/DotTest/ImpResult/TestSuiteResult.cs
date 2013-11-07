using System.Collections.Generic;
using System.Linq;
using DotTest.ImpTest;
using DotTest.Interface;

namespace DotTest.ImpResult
{
    public class TestSuiteResult : ITestResult
    {
        private List<ITestResult> _testsResult;
        public ITest _test{ get; set; }

        public TestSuiteResult(ITest test)
        {
            _test = test;
            _testsResult = new List<ITestResult>();
        }

        public int OkCount()
        {
            return _testsResult.Sum(t => t.OkCount());
        }

        public int ErrorCount()
        {
            return _testsResult.Sum(t => t.ErrorCount());
        }

        public int FailureCount()
        {
            return _testsResult.Sum(t => t.FailureCount());
        }

        public void AddTestResult(ITestResult testResult)
        {
            _testsResult.Add(testResult);
        }

        public string Print()
        {
            var ret = "";

            if (_testsResult.Any(x => x.GetType() == typeof(TestCaseResult))) ret = "\n" + _test.FullName + "\n---------------\n";
            ret += _testsResult.Aggregate("", (current, testResult) => current + testResult.Print());
            return ret;
        }

        public string PrintSummary()
        {
            var result = ErrorCount() == 0 && FailureCount() == 0 ? "[success]" : "[failure]";
            var ret = "\n" + result + "Summary\n=====================\n";
            ret += "Run: " + (OkCount() + ErrorCount() + FailureCount()) + "\n";
            ret += "Ok: " + OkCount() + "\n";
            ret += "Errors: " + ErrorCount() + "\n";
            ret += "Failures: " + FailureCount() + "\n";
            return ret;
        }

        public void AddResult(ITestResult testResult)
        {
            _testsResult.Add(testResult);
        }
    }
}
