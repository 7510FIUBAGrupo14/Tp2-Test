using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsTrueFail : TestCase
    {
        public IsTrueFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            Assert.IsTrue(false);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
