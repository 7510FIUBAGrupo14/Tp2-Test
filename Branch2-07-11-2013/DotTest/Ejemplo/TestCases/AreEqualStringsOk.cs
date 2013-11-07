using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestCases
{
    public class AreEqualStringsOk : TestCase
    {
        public AreEqualStringsOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context, ITestResult testResult = null)
        {
            var a = "a";
            var b = "a";
            Assert.AreEqual(a, b);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
