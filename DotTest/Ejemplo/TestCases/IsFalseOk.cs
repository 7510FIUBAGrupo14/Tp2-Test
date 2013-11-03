
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class IsFalseOk : TestCase
    {
        public IsFalseOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.IsFalse(false);
        }

        public override void TearDown()
        {
        }
    }
}
