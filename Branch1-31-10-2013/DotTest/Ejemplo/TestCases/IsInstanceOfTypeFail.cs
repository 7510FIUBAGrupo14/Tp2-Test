using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsInstanceOfTypeFail : ITestCase
    {
        public void Excecute()
        {
            Assert.IsInstanceOfType("a", 1.GetType());
        }
    }
}
