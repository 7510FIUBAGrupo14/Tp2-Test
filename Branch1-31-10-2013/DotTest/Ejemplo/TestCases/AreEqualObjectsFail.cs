using System.Drawing;
using DotTest;

namespace ConsoleApplication1.TestCases
{
    public class AreEqualObjectsFail : ITestCase
    {
        public void Excecute()
        {
            var a = new { linea = "a" };
            var b = new { linea = "b" };
            Assert.AreEqual(a, b);
        }
    }
}