using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualIntOk : TestCase
    {
        public AreNotEqualIntOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            var a = 1;
            var b = 2;
            Assert.AreNotEqual(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
