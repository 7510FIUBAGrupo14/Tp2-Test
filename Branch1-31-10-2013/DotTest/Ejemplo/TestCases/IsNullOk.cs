using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsNullOk : ITestCase
    {
        public void Excecute()
        {
            Assert.IsNull(null);
        }
    }
}
