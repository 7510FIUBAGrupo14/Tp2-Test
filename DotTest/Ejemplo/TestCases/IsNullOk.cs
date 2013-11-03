
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class IsNullOk : TestCase
    {
        public IsNullOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.IsNull(null);
        }

        public override void TearDown()
        {
        }
    }
}
