using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestContext
{
    public class AddTwoKeysAndRemoveTheFirstKey : TestCase
    {
        public AddTwoKeysAndRemoveTheFirstKey(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var newcontext = new Context();
            newcontext.Add("key1", "object");
            newcontext.Add("key2", 2);

            newcontext.Remove("key1");

            Assert.AreEqual(newcontext.Get("key1"), null);
            Assert.AreEqual(newcontext.Get("key2"), 2);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
