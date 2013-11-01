using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreEqualIntOk : ITestCase
    {
        public void Excecute()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(a, b);
        }
    }
}
