using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsFalseFail : TestCase
    {
        public IsFalseFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(ITestResult testResult = null)
        {
            Assert.IsFalse(true);
        }

        public override void TearDown()
        {
        }
    }
}
