
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class IsNotInstanceOfTypeFail : TestCase
    {
        public IsNotInstanceOfTypeFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.IsNotInstanceOfType("a", "a".GetType());
        }

        public override void TearDown()
        {
        }
    }
}
