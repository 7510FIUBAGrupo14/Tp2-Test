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

        /*public int Runs { get; set; }
        public int Errors { get; set; }
        public int Failures { get; set; }*/

        public TestSuiteResult(ITest test)
        {
            _test = test;
            _testsResult = new List<ITestResult>();
        }

        /*public void Initialize()
        {
            Runs = 0;
            Errors = 0;
            Failures = 0;
        }*/

        public int OkCount()
        {
            var cantidad = 0;
            foreach (var t in _testsResult){
                cantidad += t.OkCount();
            }
            return cantidad;
        }

        public int ErrorCount()
        {
            var cantidad = 0;
            foreach (var t in _testsResult)
            {
                cantidad += t.ErrorCount();
            }
            return cantidad;
        }

        public int FailureCount()
        {
            var cantidad = 0;
            foreach (var t in _testsResult)
            {
                cantidad += t.FailureCount();
            }
            return cantidad;
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
