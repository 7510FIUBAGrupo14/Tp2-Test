
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class IsNotNullOk : TestCase
    {
        public IsNotNullOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.IsNotNull(1);
        }

        public override void TearDown()
        {
        }
    }
}
