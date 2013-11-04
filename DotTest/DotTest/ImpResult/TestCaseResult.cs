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

        public TestCaseResult(ITest test, ResultType e)
        {
            _test = test;
            _e = e;
        }

        public string Print()
        {
            return "[" + _e.ToString() + "] " + _test.Name + "\n";
        }

        public void AddResult(ITestResult testResult)
        {
            throw new NotImplementedException();
        }
    }
}
