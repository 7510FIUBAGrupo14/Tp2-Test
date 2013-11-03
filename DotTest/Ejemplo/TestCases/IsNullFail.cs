
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class IsNullFail : TestCase
    {
        public IsNullFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.IsNull(1);
        }

        public override void TearDown()
        {
        }
    }
}
