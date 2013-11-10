using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class AreEqualObjectsOk : TestCase
    {
        public AreEqualObjectsOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            Assert.AreEqual(a, b);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
