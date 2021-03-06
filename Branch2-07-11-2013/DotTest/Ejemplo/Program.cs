﻿using ConsoleApplication1.TestCases;
using DotTest;
using DotTest.ImpTest;

namespace ConsoleApplication1
{
    /// <summary> 
    /// Small main program as en example of library usage 
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)
        {
            var test = new TestSuite("Suit");
            var test2 = new TestSuite("SubSuit");
            var test3 = new TestSuite("SubSubSuit");

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
            test2.AddTest(new IsFalseFail("IsFalseFail"));
            test2.AddTest(new IsTrueOk("IsTrueOk"));
            test2.AddTest(new IsTrueFail("IsTrueFail"));
            test2.AddTest(new IsNullOk("IsNullOk"));
            test2.AddTest(new IsNullFail("IsNullFail"));
            test2.AddTest(new IsNotNullOk("IsNotNullOk"));
            test2.AddTest(new IsNotNullFail("IsNotNullFail"));
            test2.AddTest(new IsInstanceOfTypeOk("IsInstanceOfTypeOk"));
            test2.AddTest(new IsInstanceOfTypeFail("IsInstanceOfTypeFail"));
            test3.AddTest(new IsNotInstanceOfTypeOk("IsNotInstanceOfTypeOk"));
            test3.AddTest(new IsNotInstanceOfTypeFail("IsNotInstanceOfTypeFail"));
            test3.AddTest(new FailVoid("FailVoid"));
            test3.AddTest(new FailWithMessage("FailWithMessage"));
            test2.AddTest(test3);
            test.AddTest(test2);

            var r = new TestRunner();
            r.AddTest(test);
            r.Execute();

            var r2 = new TestRunner();
            r2.AddTest(test);
            string pattern = @"False";
            r2.ExecuteByName(pattern);
            r2.Execute();
        }
    }
}
