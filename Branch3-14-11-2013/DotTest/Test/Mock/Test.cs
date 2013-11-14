using System;
using System.Collections.Generic;
using DotTest.ImpTest;
using DotTest.Interface;

namespace Test.Mock
{
    public class Test : TestCase
    {
        public Test(string name, IEnumerable<string> tags, bool filterable = true) : base(name, tags, filterable)
        {
        }

        public bool WasExcecuted{ get; set; }
        public override void Setup(IContext context)
        {
        }

        public override void Execute(IContext context)
        {
            WasExcecuted = true;
        }

        public override void TearDown(IContext context)
        {
        }
    }
}
