using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class FailWithMessage : TestCase
    {
        public FailWithMessage(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            Assert.Fail("Hi");
        }

        public override void TearDown()
        {
        }
    }
}
