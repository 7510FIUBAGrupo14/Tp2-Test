
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class IsTrueOk : TestCase
    {
        public IsTrueOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.IsTrue(true);
        }

        public override void TearDown()
        {
        }
    }
}
