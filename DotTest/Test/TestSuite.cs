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
        public void a()
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
        }
    }
}
