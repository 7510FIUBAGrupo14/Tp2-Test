
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class AreNotSameStringsOk : TestCase
    {
        public AreNotSameStringsOk(string nombre)
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
            Assert.AreNotSame(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
