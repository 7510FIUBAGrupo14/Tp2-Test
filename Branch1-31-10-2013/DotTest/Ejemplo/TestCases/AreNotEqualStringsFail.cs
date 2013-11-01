using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualStringsFail : ITestCase
    {
        public void Excecute()
        {
            var a = "a";
            var b = "a";
            Assert.AreNotEqual(a, b);
        }
    }
}
