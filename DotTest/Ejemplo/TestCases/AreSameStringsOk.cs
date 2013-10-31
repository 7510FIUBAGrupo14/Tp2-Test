using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreSameStringsOk : ITestCase
    {
        public void Excecute()
        {
            var a = "a";
            var b = a;
            Assert.AreSame(a, b);
        }
    }
}
