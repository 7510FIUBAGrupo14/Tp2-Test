using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsTrueFail : TestCase
    {
        public IsTrueFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            Assert.IsTrue(false);
        }

        public override void TearDown()
        {
        }
    }
}
