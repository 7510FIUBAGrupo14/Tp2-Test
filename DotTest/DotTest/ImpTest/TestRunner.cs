using DotTest.ImpResult;
using DotTest.Interface;

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
            testContainer.Execute(result);
            var r = result.Print();

        }

        public void ExecuteByName(string name)
        {
            var result = new TestSuiteResult(testContainer);
            testContainer.ExecuteByName(name, result);
            var r = result.Print();
        }
    }
}
