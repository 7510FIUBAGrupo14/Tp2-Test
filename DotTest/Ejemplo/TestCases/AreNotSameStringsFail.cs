using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreNotSameStringsFail : ITestCase
    {
        public void Excecute()
        {
            var a = "a";
            var b = a;
            Assert.AreNotSame(a, b);
        }
    }
}
