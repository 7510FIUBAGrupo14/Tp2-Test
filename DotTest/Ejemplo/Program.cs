using ConsoleApplication1.TestCases;
using ConsoleApplication1.TestFilter;
using DotTest.ImpTest;
using DotTest.Output;

namespace ConsoleApplication1
{
    /// <summary> 
    /// Small main program as en example of library usage 
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestSuite("TestCases");
            var test2 = new TestSuite("TestFilter");

            test.AddTest(new AreEqualStringsFail("AreEqualStringsFail"));
            test.AddTest(new AreEqualStringsOk("AreEqualStringsOk"));
            test.AddTest(new AreEqualObjectsFail("AreEqualObjectsFail"));
            test.AddTest(new AreEqualObjectsOk("AreEqualObjectsOk"));
            test.AddTest(new AreEqualDistinctIntFail("AreEqualDistinctIntFail"));
            test.AddTest(new AreEqualIntOk("AreEqualIntOk"));
            test.AddTest(new AreNotEqualStringsFail("AreNotEqualStringsFail"));
            test.AddTest(new AreNotEqualStringsOk("AreNotEqualStringsOk"));
            test.AddTest(new AreNotEqualObjectsFail("AreNotEqualObjectsFail"));
            test.AddTest(new AreNotEqualObjectsOk("AreNotEqualObjectsOk"));
            test.AddTest(new AreNotEqualIntFail("AreNotEqualIntFail"));
            test.AddTest(new AreNotEqualIntOk("AreNotEqualIntOk"));
            test.AddTest(new AreSameStringsOk("AreSameStringsOk"));
            test.AddTest(new AreSameStringsFail("AreSameStringsFail"));
            test.AddTest(new AreNotSameStringsOk("AreNotSameStringsOk"));
            test.AddTest(new AreNotSameStringsFail("AreNotSameStringsFail"));
            test.AddTest(new IsFalseOk("IsFalseOk"));
            test.AddTest(new IsFalseFail("IsFalseFail"));
            test.AddTest(new IsTrueOk("IsTrueOk"));
            test.AddTest(new IsTrueFail("IsTrueFail"));
            test.AddTest(new IsNullOk("IsNullOk"));
            test.AddTest(new IsNullFail("IsNullFail"));
            test.AddTest(new IsNotNullOk("IsNotNullOk"));
            test.AddTest(new IsNotNullFail("IsNotNullFail"));
            test.AddTest(new IsInstanceOfTypeOk("IsInstanceOfTypeOk"));
            test.AddTest(new IsInstanceOfTypeFail("IsInstanceOfTypeFail"));
            test.AddTest(new IsNotInstanceOfTypeOk("IsNotInstanceOfTypeOk"));
            test.AddTest(new IsNotInstanceOfTypeFail("IsNotInstanceOfTypeFail"));
            test.AddTest(new FailVoid("FailVoid"));
            test.AddTest(new FailWithMessage("FailWithMessage"));

            test2.AddTest(new FilterCaseByNameAndName("FilterCaseByNameAndName"));
            test2.AddTest(new FilterCaseByTag("FilterCaseByTag"));
            test2.AddTest(new FilterCaseByTagAndName("FilterCaseByTagAndName"));
            test2.AddTest(new FilterEmpty("FilterEmpty"));
            test2.AddTest(new FilterEmpty2("FilterEmpty2"));
            test2.AddTest(new FilterSuiteByName("FilterSuiteByName"));
            test2.AddTest(new NoFilterCaseByTag("NoFilterCaseByTag"));
            test2.AddTest(new NoFilterCaseByTagAndName("NoFilterCaseByTagAndName"));
            test2.AddTest(new NoFilterSuiteByName("NoFilterSuiteByName"));

            var r = new TestRunner();
            r.AddTest(test);
            r.AddTest(test2);
            r.Run(new DuoComponent());
            
        }
    }
}