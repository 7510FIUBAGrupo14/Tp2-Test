using System.Drawing;
using DotTest;

namespace ConsoleApplication1.TestCases
{
    public class CaseCasaSePinta : ITestCase
    {
        public void Excecute()
        {
            var casa = new Casa();
            casa.Pintar(Color.Red);
            Assert.AreEqual(casa.Color , Color.RosyBrown);
        }
    }
}
