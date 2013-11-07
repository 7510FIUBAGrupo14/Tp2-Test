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
            if (_e == ResultType.Ok)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int ErrorCount() 
        {
            if (_e == ResultType.Error)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int FailureCount() 
        {
            if (_e == ResultType.Fail)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public TestCaseResult(ITest test, ResultType e)
        {
            _test = test;
            _e = e;
        }

      /*  public void Initialize()
        {
            Runs = 0;
            Errors = 0;
            Failures = 0;
        }*/

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
