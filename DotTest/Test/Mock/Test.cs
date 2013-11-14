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

        public override void Setup(IContext context)
        {
            throw new NotImplementedException();
        }

        public override void Execute(IContext context)
        {
            throw new NotImplementedException();
        }

        public override void TearDown(IContext context)
        {
            throw new NotImplementedException();
        }
    }
}
