
using DotTest;
using DotTest.Abstracts;


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

        public override void Execute(Report reporte = null)        {
            Assert.IsNotNull(null);
        }

        public override void TearDown()
        {
        }
    }
}
