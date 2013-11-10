using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualStringsFail : TestCase
    {
        public AreNotEqualStringsFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var a = "a";
            var b = "a";
            Assert.AreNotEqual(a, b);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
