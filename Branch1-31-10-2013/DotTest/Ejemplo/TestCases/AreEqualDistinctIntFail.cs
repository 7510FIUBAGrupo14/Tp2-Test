using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreEqualDistinctIntFail : ITestCase
    {
        public void Excecute()
        {
            var a = 1;
            var b = 2;
            Assert.AreEqual(a, b);
        }
    }
}
