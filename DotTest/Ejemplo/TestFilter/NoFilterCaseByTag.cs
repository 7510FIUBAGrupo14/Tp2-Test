﻿using System.Collections.Generic;
using DotTest;
using DotTest.ImpTest;
using DotTest.Interface;

namespace ConsoleApplication1.TestFilter
{
    public class NoFilterCaseByTag : TestCase
    {
        public NoFilterCaseByTag(string nombre)
            : base(nombre, new List<string>())
        {
        }

        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            var tags = new List<string> { "uno" };
            var filter = new Filter(tags);

            var test = new Test("a", new List<string> { "uno" });

            Assert.IsFalse(filter.Skip(test));
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
