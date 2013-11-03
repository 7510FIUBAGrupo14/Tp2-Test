using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualObjectsFail : TestCase
    {
        public AreNotEqualObjectsFail(string nombre)
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
            Assert.AreNotEqual(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
