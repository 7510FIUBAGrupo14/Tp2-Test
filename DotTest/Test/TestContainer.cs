using System;
using DotTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Test
{
    [TestClass]
    public class TestContainer
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testCase = new Mock<ITestCase>();
        }
    }
}
