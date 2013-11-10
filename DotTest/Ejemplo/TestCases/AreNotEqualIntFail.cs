using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualIntFail : TestCase
    {
        public AreNotEqualIntFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var a = 1;
            var b = 1;
            Assert.AreNotEqual(a, b);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
