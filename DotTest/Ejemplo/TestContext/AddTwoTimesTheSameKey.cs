using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;


namespace ConsoleApplication1.TestContext
{
    public class AddTwoTimesTheSameKey : TestCase
    {
        public AddTwoTimesTheSameKey(string nombre)
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
            newcontext.Add("key", 1);

            Assert.AreEqual(newcontext.Get<int>("key"), 1);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
