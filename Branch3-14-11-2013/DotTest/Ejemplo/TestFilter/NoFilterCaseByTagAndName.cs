using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestFilter
{
    public class NoFilterCaseByTagAndName : TestCase
    {
        public NoFilterCaseByTagAndName(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var tags = new List<string> { "uno" };
            var filter = new Filter("b", tags);

            var test = new Test("a", new List<string> { "uno" });

            Assert.IsTrue(filter.Skip(test));
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
