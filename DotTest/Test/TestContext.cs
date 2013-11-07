using DotTest.ImpTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestContext
    {
        [TestMethod]
        public void Add1()
        {
            var context = new Context();
            context.Add("key", "object");

            Assert.AreEqual(context.Get<string>("key"), "object");
        }

        [TestMethod]
        public void Add2()
        {
            var context = new Context();
            context.Add("key", "object");
            context.Add("key", 1);

            Assert.AreEqual(context.Get<int>("key"), 1);
        }

        [TestMethod]
        public void Remove()
        {
            var context = new Context();
            context.Add("key", "object");
            context.Remove("key");

            Assert.AreEqual(context.Get("key"), null);
        }

    }
}
