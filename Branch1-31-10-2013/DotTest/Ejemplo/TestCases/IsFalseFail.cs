using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsFalseFail : ITestCase
    {
        public void Excecute()
        {
            Assert.IsFalse(true);
        }
    }
}
