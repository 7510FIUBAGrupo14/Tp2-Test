using System.Collections.Generic;
using DotTest;
using DotTest.Component;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestsSuite
{
    public class ExecuteByNoNameAndTag : TestCase
    {
        public ExecuteByNoNameAndTag(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var case1 = new Test("T1", new List<string> { "Slow" });
            var case2 = new Test("T2", new List<string> { "Fast" });
            var case3 = new Test("T3", new List<string> { "Slow" });
            var case4 = new Test("no correr", new List<string> { "Slow" });

            var filtro = new Filter("^(?:(?!no correr).)*", new List<string> { "Slow" });
            var suite = new TestSuite("suite");

            suite.AddTest(case1);
            suite.AddTest(case2);
            suite.AddTest(case3);
            suite.AddTest(case4);

            var component = new MockComponent();
            suite.Run(new Context(), component, filtro);

            Assert.IsTrue(case1.WasExcecuted);
            Assert.IsFalse(case2.WasExcecuted);
            Assert.IsTrue(case3.WasExcecuted);
            Assert.IsFalse(case4.WasExcecuted);
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
