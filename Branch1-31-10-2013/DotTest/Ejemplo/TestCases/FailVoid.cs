using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class FailVoid : ITestCase
    {
        public void Excecute()
        {
            Assert.Fail();
        }
    }
}
