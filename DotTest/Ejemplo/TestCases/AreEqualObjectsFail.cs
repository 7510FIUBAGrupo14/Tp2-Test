using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestCases
{
    public class AreEqualObjectsFail : TestCase
    {
        public AreEqualObjectsFail(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var a = new { linea = "a" };
            var b = new { linea = "b" };
            Assert.AreEqual(a, b);
        }

        public override void TearDown(IContext context)
        {
        }

    }
}