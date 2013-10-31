using System.Drawing;
using DotTest;

namespace ConsoleApplication1.TestCases
{
    public class AreEqualStringsFail : ITestCase
    {
        public void Excecute()
        {
            var a = "a";
            var b = "b";
            Assert.AreEqual(a, b);
        }
    }
}
