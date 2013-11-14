using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestContext
{
    public class RemoveUnexpectedKey : TestCase
    {
        public RemoveUnexpectedKey(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var newcontext = new Context();
            newcontext.Remove("key");

            Assert.AreEqual(newcontext.Get("key"), null);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
