using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestCases
{
    public class IsInstanceOfTypeFail : TestCase
    {
        public IsInstanceOfTypeFail(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            Assert.IsInstanceOfType("a", 1.GetType());
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
