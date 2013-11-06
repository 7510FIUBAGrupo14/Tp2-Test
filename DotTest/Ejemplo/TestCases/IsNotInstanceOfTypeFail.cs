using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsNotInstanceOfTypeFail : TestCase
    {
        public IsNotInstanceOfTypeFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context, ITestResult testResult = null)
        {
            Assert.IsNotInstanceOfType("a", "a".GetType());
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
