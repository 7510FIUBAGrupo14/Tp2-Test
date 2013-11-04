using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsInstanceOfTypeOk : TestCase
    {
        public IsInstanceOfTypeOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            Assert.IsInstanceOfType("a", "a".GetType());
        }

        public override void TearDown()
        {
        }
    }
}
