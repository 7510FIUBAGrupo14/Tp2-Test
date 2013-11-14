using System.Collections.Generic;
using DotTest.ImpTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestFilter
    {
        [TestMethod]
        public void a()
        {
            var tags = new List<string>();
            var filter = new Filter(tags);

            var test = new TestSuite("a");

            Assert.IsFalse(filter.Skip(test));
        }

        [TestMethod]
        public void b()
        {
            var tags = new List<string>();
            var filter = new Filter("","b",tags);

            var test = new TestSuite("a");

            Assert.IsTrue(filter.Skip(test));
        }

        [TestMethod]
        public void c()
        {
            var tags = new List<string>();
            var filter = new Filter("a", tags);

            var test = new TestSuite("a");

            Assert.IsFalse(filter.Skip(test));
        }

        [TestMethod]
        public void d()
        {
            var tags = new List<string>{"uno"};
            var filter = new Filter(tags);

            var test = new Mock.Test("a", new List<string> {"dos"});

            Assert.IsTrue(filter.Skip(test));
        }

        [TestMethod]
        public void e()
        {
            var tags = new List<string> { "uno" };
            var filter = new Filter(tags);

            var test = new Mock.Test("a", new List<string> { "uno" });

            Assert.IsFalse(filter.Skip(test));
        }

        [TestMethod]
        public void f()
        {
            var tags = new List<string> { "uno" };
            var filter = new Filter("b",tags);

            var test = new Mock.Test("a", new List<string> { "uno" });

            Assert.IsTrue(filter.Skip(test));
        }

        [TestMethod]
        public void g()
        {
            var tags = new List<string> { "dos" };
            var filter = new Filter("a", tags);

            var test = new Mock.Test("a", new List<string> { "uno" });

            Assert.IsTrue(filter.Skip(test));
        }

        [TestMethod]
        public void h()
        {
            var tags = new List<string> { "uno" };
            var filter = new Filter("a", tags);

            var test = new Mock.Test("a", new List<string> { "uno" });

            Assert.IsFalse(filter.Skip(test));
        }
    }
}
