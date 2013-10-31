using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsTrueFail : ITestCase
    {
        public void Excecute()
        {
            Assert.IsTrue(false);
        }
    }
}
