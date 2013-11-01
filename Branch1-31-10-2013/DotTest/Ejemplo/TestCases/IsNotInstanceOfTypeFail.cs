using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsNotInstanceOfTypeFail : ITestCase
    {
        public void Excecute()
        {
            Assert.IsNotInstanceOfType("a", "a".GetType());
        }
    }
}
