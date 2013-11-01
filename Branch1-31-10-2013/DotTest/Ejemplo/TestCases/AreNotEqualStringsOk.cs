using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreNotEqualStringsOk : ITestCase
    {
        public void Excecute()
        {
            var a = "a";
            var b = "b";
            Assert.AreNotEqual(a, b);
        }
    }
}
