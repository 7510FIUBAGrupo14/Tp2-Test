using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestContext
{
    public class AddOneKey : TestCase
    {
        public AddOneKey(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var newcontext = new Context();
            newcontext.Add("key", "object");

            Assert.AreEqual(newcontext.Get<string>("key"), "object");
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
