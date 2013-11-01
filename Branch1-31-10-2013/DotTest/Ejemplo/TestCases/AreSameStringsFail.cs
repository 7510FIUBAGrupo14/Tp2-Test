using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreSameStringsFail : ITestCase
    {
        public void Excecute()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            Assert.AreSame(a, b);
        }
    }
}
