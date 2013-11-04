using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestCases
{
    public class IsNotInstanceOfTypeOk : TestCase
    {
        public IsNotInstanceOfTypeOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            Assert.IsNotInstanceOfType("a", 1.GetType());
        }

        public override void TearDown()
        {
        }
    }
}
