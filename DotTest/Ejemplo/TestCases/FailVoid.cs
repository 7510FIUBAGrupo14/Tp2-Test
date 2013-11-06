using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class FailVoid : TestCase
    {
        public FailVoid(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context, ITestResult testResult = null)
        {
            Assert.Fail();
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
