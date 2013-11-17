using ConsoleApplication1.TestCases;
using ConsoleApplication1.TestContext;
using ConsoleApplication1.TestFilter;
using ConsoleApplication1.TestsSuite;
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
            var testAsserts = new TestSuite("TestAsserts");
            var testFilter = new TestSuite("TestFilter");
            var testSuite = new TestSuite("TestSuite");
            var testContext = new TestSuite("TestContext");

            testAsserts.AddTest(new AreEqualStringsFail("AreEqualStringsFail"));
            testAsserts.AddTest(new AreEqualStringsOk("AreEqualStringsOk"));
            testAsserts.AddTest(new AreEqualObjectsFail("AreEqualObjectsFail"));
            testAsserts.AddTest(new AreEqualObjectsOk("AreEqualObjectsOk"));
            testAsserts.AddTest(new AreEqualDistinctIntFail("AreEqualDistinctIntFail"));
            testAsserts.AddTest(new AreEqualIntOk("AreEqualIntOk"));
            testAsserts.AddTest(new AreNotEqualStringsFail("AreNotEqualStringsFail"));
            testAsserts.AddTest(new AreNotEqualStringsOk("AreNotEqualStringsOk"));
            testAsserts.AddTest(new AreNotEqualObjectsFail("AreNotEqualObjectsFail"));
            testAsserts.AddTest(new AreNotEqualObjectsOk("AreNotEqualObjectsOk"));
            testAsserts.AddTest(new AreNotEqualIntFail("AreNotEqualIntFail"));
            testAsserts.AddTest(new AreNotEqualIntOk("AreNotEqualIntOk"));
            testAsserts.AddTest(new AreSameStringsOk("AreSameStringsOk"));
            testAsserts.AddTest(new AreSameStringsFail("AreSameStringsFail"));
            testAsserts.AddTest(new AreNotSameStringsOk("AreNotSameStringsOk"));
            testAsserts.AddTest(new AreNotSameStringsFail("AreNotSameStringsFail"));
            testAsserts.AddTest(new IsFalseOk("IsFalseOk"));
            testAsserts.AddTest(new IsFalseFail("IsFalseFail"));
            testAsserts.AddTest(new IsTrueOk("IsTrueOk"));
            testAsserts.AddTest(new IsTrueFail("IsTrueFail"));
            testAsserts.AddTest(new IsNullOk("IsNullOk"));
            testAsserts.AddTest(new IsNullFail("IsNullFail"));
            testAsserts.AddTest(new IsNotNullOk("IsNotNullOk"));
            testAsserts.AddTest(new IsNotNullFail("IsNotNullFail"));
            testAsserts.AddTest(new IsInstanceOfTypeOk("IsInstanceOfTypeOk"));
            testAsserts.AddTest(new IsInstanceOfTypeFail("IsInstanceOfTypeFail"));
            testAsserts.AddTest(new IsNotInstanceOfTypeOk("IsNotInstanceOfTypeOk"));
            testAsserts.AddTest(new IsNotInstanceOfTypeFail("IsNotInstanceOfTypeFail"));
            testAsserts.AddTest(new FailVoid("FailVoid"));
            testAsserts.AddTest(new FailWithMessage("FailWithMessage"));

            testFilter.AddTest(new FilterCaseByNameAndName("FilterCaseByNameAndName"));
            testFilter.AddTest(new FilterCaseByTag("FilterCaseByTag"));
            testFilter.AddTest(new FilterCaseByTagAndName("FilterCaseByTagAndName"));
            testFilter.AddTest(new FilterEmpty("FilterEmpty"));
            testFilter.AddTest(new FilterEmpty2("FilterEmpty2"));
            testFilter.AddTest(new FilterSuiteByName("FilterSuiteByName"));
            testFilter.AddTest(new NoFilterCaseByTag("NoFilterCaseByTag"));
            testFilter.AddTest(new NoFilterCaseByTagAndName("NoFilterCaseByTagAndName"));
            testFilter.AddTest(new NoFilterSuiteByName("NoFilterSuiteByName"));

            testSuite.AddTest(new ExecuteByNameAndTag("ExecuteByNameAndTag"));
            testSuite.AddTest(new ExecuteByNoNameAndTag("ExecuteByNoNameAndTag"));

            testContext.AddTest(new AddOneKey("AddOneKey"));
            testContext.AddTest(new AddTwoKeysAndRemoveTheFirstKey("AddTwoKeysAndRemoveTheFirstKey"));
            testContext.AddTest(new AddTwoTimesTheSameKey("AddTwoTimesTheSameKey"));
            testContext.AddTest(new RemoveOneKey("RemoveOneKey"));
            testContext.AddTest(new RemoveUnexpectedKey("RemoveUnexpectedKey"));

            var r = new TestRunner();
            r.AddTest(testAsserts);
            r.AddTest(testFilter);
            r.AddTest(testSuite);
            r.AddTest(testContext);

            var inoutComponent = new DuoComponent();
            r.Run(inoutComponent, new Filter(inoutComponent));
            
        }
    }
}