using System.Collections.Generic;
using DotTest.ImpTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestFilter
    {
        [TestMethod]
        public void FilterEmpty()
        {
            var tags = new List<string>();
            var filter = new Filter(tags);

            var test = new TestSuite("a");

            Assert.IsFalse(filter.Skip(test));
        }

        [TestMethod]
        public void NoFilterSuiteByName()
        {
            var tags = new List<string>();
            var filter = new Filter("","b",tags);

            var test = new TestSuite("a");

            Assert.IsTrue(filter.Skip(test));
        }

        [TestMethod]
        public void FilterSuiteByName()
        {
            var tags = new List<string>();
            var filter = new Filter("a", tags);

            var test = new TestSuite("a");

            Assert.IsFalse(filter.Skip(test));
        }

        [TestMethod]
        public void FilterCaseByTag()
        {
            var tags = new List<string>{"uno"};
            var filter = new Filter(tags);

            var test = new Mock.Test("a", new List<string> {"dos"});

            Assert.IsTrue(filter.Skip(test));
        }

        [TestMethod]
        public void NoFilterCaseByTag()
        {
            var tags = new List<string> { "uno" };
            var filter = new Filter(tags);

            var test = new Mock.Test("a", new List<string> { "uno" });

            Assert.IsFalse(filter.Skip(test));
        }

        [TestMethod]
        public void FilterCaseByNameAndName()
        {
            var tags = new List<string> { "uno" };
            var filter = new Filter("b",tags);

            var test = new Mock.Test("a", new List<string> { "uno" });

            Assert.IsTrue(filter.Skip(test));
        }

        [TestMethod]
        public void FilterCaseByTagAndName()
        {
            var tags = new List<string> { "dos" };
            var filter = new Filter("a", tags);

            var test = new Mock.Test("a", new List<string> { "uno" });

            Assert.IsTrue(filter.Skip(test));
        }

        [TestMethod]
        public void NoFilterCaseByTagAndName()
        {
            var tags = new List<string> { "uno" };
            var filter = new Filter("a", tags);

            var test = new Mock.Test("a", new List<string> { "uno" });

            Assert.IsFalse(filter.Skip(test));
        }

        [TestMethod]
        public void FilterEmpty2()
        {
            var tags = new List<string>();
            var filter = new Filter(tags);

            var test2 = new Mock.Test("a", new List<string> { "dos" });

            Assert.IsFalse(filter.Skip(test2));

        }
    }
}
