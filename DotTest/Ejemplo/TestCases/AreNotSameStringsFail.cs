using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class AreNotSameStringsFail : TestCase
    {
        public AreNotSameStringsFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context, ITestResult testResult = null)
        {
            var a = "a";
            var b = a;
            Assert.AreNotSame(a, b);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
