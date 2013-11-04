using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsNotNullFail : TestCase
    {
        public IsNotNullFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            Assert.IsNotNull(null);
        }

        public override void TearDown()
        {
        }
    }
}
