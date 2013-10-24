using ConsoleApplication1.TestCases;
using DotTest;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestContainer();
            test.AddTestCase(new CaseCasaSePinta());
            var resultado = test.ExcecuteAll();
        }
    }
}
