using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class AreSameStringsOk : TestCase
    {
        public AreSameStringsOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            var a = "a";
            var b = a;
            Assert.AreSame(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
