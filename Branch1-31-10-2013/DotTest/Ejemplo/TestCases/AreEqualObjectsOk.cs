using System.Drawing;
using DotTest;


namespace ConsoleApplication1.TestCases
{
    public class AreEqualObjectsOk : ITestCase
    {
        public void Excecute()
        {
            var a = new { linea = "a" };
            var b = new { linea = "a" };
            Assert.AreEqual(a, b);
        }
    }
}
