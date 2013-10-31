using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsFalseOk : ITestCase
    {
        public void Excecute()
        {
            Assert.IsFalse(false);
        }
    }
}
