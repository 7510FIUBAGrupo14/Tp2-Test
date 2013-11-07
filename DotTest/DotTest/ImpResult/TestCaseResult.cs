using System;
using DotTest.Enum;
using DotTest.ImpTest;
using DotTest.Interface;

namespace DotTest.ImpResult
{
    public class TestCaseResult : ITestResult
    {
        private ITest _test;
        private ResultType _e;

        public int OkCount()
        {
            return _e == ResultType.Ok ? 1 : 0;
        }

        public int ErrorCount()
        {
            return _e == ResultType.Error ? 1 : 0;
        }

        public int FailureCount()
        {
            return _e == ResultType.Fail ? 1 : 0;
        }

        public TestCaseResult(ITest test, ResultType e)
        {
            _test = test;
            _e = e;
        }

        public string Print()
        {
            return "[" + _e + "] " + _test.Name + "\n";
        }

        public string PrintSummary()
        {
            return "";
        }

        public void AddResult(ITestResult testResult)
        {
            throw new NotImplementedException();
        }
    }
}
