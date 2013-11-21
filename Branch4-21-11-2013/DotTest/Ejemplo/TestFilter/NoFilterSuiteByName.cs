using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestFilter
{
    public class NoFilterSuiteByName : TestCase
    {
        public NoFilterSuiteByName(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var tags = new List<string>();
            var filter = new Filter("", "b", tags);

            var test = new TestSuite("a");

            Assert.IsTrue(filter.Skip(Factory.SuiteDto(test)));
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
