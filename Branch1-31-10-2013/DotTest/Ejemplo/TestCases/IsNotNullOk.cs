using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsNotNullOk : ITestCase
    {
        public void Excecute()
        {
            Assert.IsNotNull(1);
        }
    }
}
