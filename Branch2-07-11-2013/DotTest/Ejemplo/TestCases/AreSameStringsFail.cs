using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class AreSameStringsFail : TestCase
    {
        public AreSameStringsFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context, ITestResult testResult = null)
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            Assert.AreSame(a, b);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
