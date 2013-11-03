
using DotTest;
using DotTest.Abstracts;


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

        public override void Execute(Report reporte = null)
        {
            Assert.IsTrue(false);
        }

        public override void TearDown()
        {
        }
    }
}
