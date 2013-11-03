
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class AreSameStringsFail : TestCase
    {
        public AreSameStringsFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            Assert.AreSame(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
