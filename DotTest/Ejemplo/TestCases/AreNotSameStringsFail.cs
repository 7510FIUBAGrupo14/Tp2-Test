
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class AreNotSameStringsFail : TestCase
    {
        public AreNotSameStringsFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            var a = "a";
            var b = a;
            Assert.AreNotSame(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
