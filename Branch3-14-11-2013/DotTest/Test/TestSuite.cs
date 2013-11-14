using System.Collections.Generic;
using DotTest.ImpTest;
using DotTest.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class TestTestSuite
    {
        [TestMethod]
        public void ExecuteByNameAndTag()
        {
            var case1 = new Mock.Test("T1", new List<string> { "DB" });
            var case2 = new Mock.Test("T2", new List<string> { "DB" });
            var case3 = new Mock.Test("T3", new List<string> { "Slow" });
            var case4 = new Mock.Test("... mysql ..1", new List<string> { "DB" });
            var case5 = new Mock.Test("... mysql ..2", new List<string> { "DB" });
            var case6 = new Mock.Test("... mysql ..3", new List<string> { "*" });

            var filtro = new Filter("mysql", new List<string> {"DB"});
            var suite = new TestSuite("suite");

            suite.AddTest(case1);
            suite.AddTest(case2);
            suite.AddTest(case3);
            suite.AddTest(case4);
            suite.AddTest(case5);
            suite.AddTest(case6);

            var component = new Mock<IOutputComponent>();
            suite.Run(new Context(), component.Object,filtro);

            Assert.IsFalse(case1.WasExcecuted);
            Assert.IsFalse(case2.WasExcecuted);
            Assert.IsFalse(case3.WasExcecuted);
            Assert.IsTrue(case4.WasExcecuted);
            Assert.IsTrue(case5.WasExcecuted);
            Assert.IsFalse(case6.WasExcecuted);
        }

        [TestMethod]
        public void ExecuteByNoNameAndTag()
        {
            var case1 = new Mock.Test("T1", new List<string> { "Slow" });
            var case2 = new Mock.Test("T2", new List<string> { "Fast" });
            var case3 = new Mock.Test("T3", new List<string> { "Slow" });
            var case4 = new Mock.Test("no correr", new List<string> { "Slow" });

            var filtro = new Filter("^(?:(?!no correr).)*", new List<string> { "Slow" });
            var suite = new TestSuite("suite");

            suite.AddTest(case1);
            suite.AddTest(case2);
            suite.AddTest(case3);
            suite.AddTest(case4);

            var component = new Mock<IOutputComponent>();
            suite.Run(new Context(), component.Object, filtro);

            Assert.IsTrue(case1.WasExcecuted);
            Assert.IsFalse(case2.WasExcecuted);
            Assert.IsTrue(case3.WasExcecuted);
            Assert.IsFalse(case4.WasExcecuted);
        }
    }
}
