using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsNotNullOk : TestCase
    {
        public IsNotNullOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            Assert.IsNotNull(1);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
