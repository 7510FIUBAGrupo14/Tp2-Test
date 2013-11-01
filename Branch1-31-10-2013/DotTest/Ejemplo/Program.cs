using ConsoleApplication1.TestCases;
using DotTest;

namespace ConsoleApplication1
{
    /// <summary> 
    /// Small main program as en example of library usage 
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestContainer();
        
            test.AddTestCase(new AreEqualStringsFail());
            test.AddTestCase(new AreEqualStringsOk());
            test.AddTestCase(new AreEqualObjectsFail());
            test.AddTestCase(new AreEqualObjectsOk());
            test.AddTestCase(new AreEqualDistinctIntFail());
            test.AddTestCase(new AreEqualIntOk());
            test.AddTestCase(new AreNotEqualStringsFail());
            test.AddTestCase(new AreNotEqualStringsOk());
            test.AddTestCase(new AreNotEqualObjectsFail());
            test.AddTestCase(new AreNotEqualObjectsOk());
            test.AddTestCase(new AreNotEqualIntFail());
            test.AddTestCase(new AreNotEqualIntOk());
            test.AddTestCase(new AreSameStringsOk());
            test.AddTestCase(new AreSameStringsFail());
            test.AddTestCase(new AreNotSameStringsOk());
            test.AddTestCase(new AreNotSameStringsFail());
            test.AddTestCase(new IsFalseOk());
            test.AddTestCase(new IsFalseFail());
            test.AddTestCase(new IsTrueOk());
            test.AddTestCase(new IsTrueFail());
            test.AddTestCase(new IsNullOk());
            test.AddTestCase(new IsNullFail());
            test.AddTestCase(new IsNotNullOk());
            test.AddTestCase(new IsNotNullFail());
            test.AddTestCase(new IsInstanceOfTypeOk());
            test.AddTestCase(new IsInstanceOfTypeFail());
            test.AddTestCase(new IsNotInstanceOfTypeOk());
            test.AddTestCase(new IsNotInstanceOfTypeFail());
            test.AddTestCase(new FailVoid());
            test.AddTestCase(new FailWithMessage());

            var resultado = test.ExcecuteAll();
        }
    }
}
