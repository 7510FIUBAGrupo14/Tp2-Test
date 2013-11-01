using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class IsTrueOk : ITestCase
    {
        public void Excecute()
        {
            Assert.IsTrue(true);
        }
    }
}
