using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestFilter
{
    public class FilterEmpty2 : TestCase
    {
        public FilterEmpty2(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var tags = new List<string>();
            var filter = new Filter(tags);

            var test2 = new Test("a", new List<string> { "dos" });

            Assert.IsFalse(filter.Skip(Factory.CaseDto(test2)));
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
