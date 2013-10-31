using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsNullFail : ITestCase
    {
        public void Excecute()
        {
            Assert.IsNull(1);
        }
    }
}
