using DotTest.ImpTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestContext
    {
        [TestMethod]
        public void AddOneKey()
        {
            var context = new Context();
            context.Add("key", "object");

            Assert.AreEqual(context.Get<string>("key"), "object");
        }

        [TestMethod]
        public void AddTwoTimesTheSameKey()
        {
            var context = new Context();
            context.Add("key", "object");
            context.Add("key", 1);

            Assert.AreEqual(context.Get<int>("key"), 1);
        }

        [TestMethod]
        public void RemoveOneKey()
        {
            var context = new Context();
            context.Add("key", "object");
            context.Remove("key");

            Assert.AreEqual(context.Get("key"), null);
        }

        [TestMethod]
        public void RemoveUnexpectedKey()
        {
            var context = new Context();
            context.Remove("key");

            Assert.AreEqual(context.Get("key"), null);
        }

        [TestMethod]
        public void AddTwoKeysAndRemoveTheFirstKey()
        {
            var context = new Context();
            context.Add("key1", "object");
            context.Add("key2", 2);

            context.Remove("key1");

            Assert.AreEqual(context.Get("key1"), null);
            Assert.AreEqual(context.Get("key2"), 2);
        }

    }
}
