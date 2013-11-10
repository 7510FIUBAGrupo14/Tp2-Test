using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsTrueOk : TestCase
    {
        public IsTrueOk(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            Assert.IsTrue(true);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
