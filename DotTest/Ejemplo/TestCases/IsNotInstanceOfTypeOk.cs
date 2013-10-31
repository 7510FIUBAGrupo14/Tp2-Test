using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsNotInstanceOfTypeOk : ITestCase
    {
        public void Excecute()
        {
            Assert.IsNotInstanceOfType("a", 1.GetType());
        }
    }
}
