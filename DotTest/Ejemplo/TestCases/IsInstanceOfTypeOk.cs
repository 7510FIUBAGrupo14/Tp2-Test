
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class IsInstanceOfTypeOk : TestCase
    {
        public IsInstanceOfTypeOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.IsInstanceOfType("a", "a".GetType());
        }

        public override void TearDown()
        {
        }
    }
}
