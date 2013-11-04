using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsInstanceOfTypeFail : TestCase
    {
        public IsInstanceOfTypeFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            Assert.IsInstanceOfType("a", 1.GetType());
        }

        public override void TearDown()
        {
        }
    }
}
