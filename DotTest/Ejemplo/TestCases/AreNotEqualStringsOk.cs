using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualStringsOk : TestCase
    {
        public AreNotEqualStringsOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            var a = "a";
            var b = "b";
            Assert.AreNotEqual(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
