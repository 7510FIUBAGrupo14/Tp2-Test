﻿using DotTest.ImpResult;
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
            PrintFile(result.Print());
        }

        public void ExecuteByName(string name)
        {
            var result = new TestSuiteResult(testContainer);
            var context = new Context();
            testContainer.ExecuteByName(name, context, result);
            PrintFile(result.Print());
        }

        private void PrintFile(string text)
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            File.WriteAllText(directory.FullName + "\\TestReport_" + DateTime.Now.ToFileTime(), text);
        }
    }
}
