
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class IsInstanceOfTypeFail : TestCase
    {
        public IsInstanceOfTypeFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.IsInstanceOfType("a", 1.GetType());
        }

        public override void TearDown()
        {
        }
    }
}
