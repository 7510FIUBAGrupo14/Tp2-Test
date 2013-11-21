using System.Collections.Generic;
using System.Threading;
using DotTest;
using DotTest.Component;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestsSuite
{
    public class ExecuteByNameAndTag : TestCase
    {
        public ExecuteByNameAndTag(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var case1 = new Test("T1", new List<string> { "DB" });
            var case2 = new Test("T2", new List<string> { "DB" });
            var case3 = new Test("T3", new List<string> { "Slow" });
            var case4 = new Test("... mysql ..1", new List<string> { "DB" });
            var case5 = new Test("... mysql ..2", new List<string> { "DB" });
            var case6 = new Test("... mysql ..3", new List<string> { "*" });

            var filtro = new Filter("mysql", new List<string> { "DB" });
            var suite = new TestSuite("suite");

            suite.AddTest(case1);
            suite.AddTest(case2);
            suite.AddTest(case3);
            suite.AddTest(case4);
            suite.AddTest(case5);
            suite.AddTest(case6);

            var component = new MockComponent();
            suite.Run(new Context(), component, filtro);

            Assert.IsFalse(case1.WasExcecuted || case2.WasExcecuted || case3.WasExcecuted || case6.WasExcecuted);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
