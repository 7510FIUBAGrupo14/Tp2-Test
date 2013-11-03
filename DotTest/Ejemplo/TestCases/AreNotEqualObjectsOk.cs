using DotTest;
using DotTest.Abstracts;

namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualObjectsOk : TestCase
    {
        public AreNotEqualObjectsOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            var a = new { linea = "a" };
            var b = new { linea = "b" };
            Assert.AreNotEqual(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
