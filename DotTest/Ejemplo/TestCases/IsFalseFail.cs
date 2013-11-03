
using DotTest;
using DotTest.Abstracts;


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

        public override void Execute(Report reporte = null)
        {
            Assert.IsFalse(true);
        }

        public override void TearDown()
        {
        }
    }
}
