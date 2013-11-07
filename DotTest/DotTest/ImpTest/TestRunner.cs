using DotTest.ImpResult;
using DotTest.Interface;
using System;
using System.IO;

namespace DotTest.ImpTest
{
    public class TestRunner
    {
        private readonly TestSuite testContainer;

        public TestRunner()
        {
            testContainer = new TestSuite("");
        }

        public bool AddTest(ITest test)
        {
            return testContainer.AddTest(test);
        }

        public void Execute()
        {
            var result = new TestSuiteResult(testContainer);
            var context = new Context();
            testContainer.Execute(context, result);
            int total = result.OkCount() + result.ErrorCount() + result.FailureCount();
            PrintFile(result.Print() + "\n[failure] Summary\n" + "\n---------------\n---------------\n" + "Runs: " + total + "\nErrors: " + result.ErrorCount() + "\nFailures: " + result.FailureCount() + "\n");
        }

        public void ExecuteByName(string name)
        {
            var result = new TestSuiteResult(testContainer);
            var context = new Context();
            testContainer.ExecuteByName(name, context, result);
            int total = result.OkCount() + result.ErrorCount() + result.FailureCount();
            PrintFile(result.Print() + "\n[failure] Summary\n" + "\n---------------\n---------------\n" + "Runs: " + total + "\nErrors: " + result.ErrorCount() + "\nFailures: " + result.FailureCount() + "\n");
        }

        private void PrintFile(string text)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            File.WriteAllText(directory.FullName + "\\TestReport_" + DateTime.Now.ToFileTime(), text);
        }
    }
}
