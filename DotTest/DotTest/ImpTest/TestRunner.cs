using System.Collections.Generic;
using System.Linq;
using DotTest.Interface;

namespace DotTest.ImpTest
{
    /// <summary> 
    /// Add user tests and runs them.
    /// </summary>
    
    public class TestRunner
    {
        private readonly TestSuite testContainer;
        public TestRunner()
        {
            testContainer = new TestSuite("Root", false);
        }

        public bool AddTest(ITest test)
        {
            return testContainer.AddTest(test);
        }

        public void Run(IOutputComponent component, IFilter filter = null)
        {
            var context = new Context();
            testContainer.Run(context, component, filter);
            component.PrintSummary();
        }
    }
}
