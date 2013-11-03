
using DotTest;
using DotTest.Abstracts;


namespace ConsoleApplication1.TestCases
{
    public class FailWithMessage : TestCase
    {
        public FailWithMessage(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            Assert.Fail("Hi");
        }

        public override void TearDown()
        {
        }
    }
}
