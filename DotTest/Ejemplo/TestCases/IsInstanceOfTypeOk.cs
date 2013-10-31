using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsInstanceOfTypeOk : ITestCase
    {
        public void Excecute()
        {
            Assert.IsInstanceOfType("a", "a".GetType());
        }
    }
}
