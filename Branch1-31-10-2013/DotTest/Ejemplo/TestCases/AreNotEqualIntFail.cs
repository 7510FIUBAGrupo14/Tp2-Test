using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualIntFail : ITestCase
    {
        public void Excecute()
        {
            var a = 1;
            var b = 1;
            Assert.AreNotEqual(a, b);
        }
    }
}
