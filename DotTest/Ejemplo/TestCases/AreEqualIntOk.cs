using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class AreEqualIntOk : TestCase
    {
        public AreEqualIntOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
