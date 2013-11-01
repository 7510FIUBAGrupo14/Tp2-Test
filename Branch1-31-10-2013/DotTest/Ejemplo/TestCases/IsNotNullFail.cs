using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsNotNullFail : ITestCase
    {
        public void Excecute()
        {
            Assert.IsNotNull(null);
        }
    }
}
