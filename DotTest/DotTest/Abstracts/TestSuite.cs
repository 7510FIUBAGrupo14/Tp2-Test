using System.Collections.Generic;
using System.Linq;
using DotTest.Interface;

namespace DotTest.Abstracts
{
    /// <summary> 
    /// Container of user test cases. Allows to store new user test and to excecute them all usabillity
    /// </summary>

    public abstract class TestSuite : ITest
    {
        private readonly List<ITest> _tests;
        public string FullName { get { return Path + "\\" + Name; } }
        public string Name { get; set; }
        public string Path { get; set; }
        public abstract void Setup();
        public abstract void TearDown();

        protected TestSuite(string name)
        {
            _tests = new List<ITest>();
            Name = name;
        }
        
        public void AddTest(ITest test)
        {
            test.Path = FullName;
            _tests.Add(test);
        }

        public void Execute(Report report)
        {
            foreach (var test in _tests)
            {
                try
                {
                    test.Setup();
                    test.Execute(report);
                }
                catch (AssertException e)
                {
                    report.Errors.Insert(0,test.FullName + ": " + e.Message);
                }
                finally
                {
                    test.TearDown();
                }
            }
        }
    }
}
