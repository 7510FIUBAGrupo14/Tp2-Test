using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class FailWithMessage : ITestCase
    {
        public void Excecute()
        {
            Assert.Fail("Hi");
        }
    }
}
