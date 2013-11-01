using System;
using System.Collections.Generic;
using System.Linq;

namespace DotTest
{
    /// <summary> 
    /// Container of user test cases. Allows to store new user test and to excecute them all usabillity
    /// </summary>

    public class TestContainer
    {
        private readonly List<ITestCase> _testCases;

        public TestContainer()
        {
            _testCases = new List<ITestCase>();
        }

        public void AddTestCase(ITestCase testCase)
        {
            _testCases.Add(testCase);
        }

        public Report ExcecuteAll()
        {
            var report = new Report();
            foreach (var test in _testCases)
            {
                try
                {
                    test.Excecute();
                }
                catch(AssertException e)
                {
                    report.Errors.Add(test.ToString().Split('.').Last() + ": " + e.Message);
                }
            }
            return report;
        }
    }
}
