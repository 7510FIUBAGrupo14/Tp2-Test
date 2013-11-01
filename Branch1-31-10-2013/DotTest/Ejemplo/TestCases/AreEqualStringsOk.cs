using System.Drawing;
using DotTest;

namespace ConsoleApplication1.TestCases
{
    public class AreEqualStringsOk : ITestCase
    {
        public void Excecute()
        {
            var a = "a";
            var b = "a";
            Assert.AreEqual(a, b);
        }
    }
}
