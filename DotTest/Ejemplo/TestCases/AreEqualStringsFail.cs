﻿using DotTest;
using DotTest.Abstracts;

namespace ConsoleApplication1.TestCases
{
    public class AreEqualStringsFail : TestCase
    {
        public AreEqualStringsFail(string nombre)
            : base(nombre)
        {
        }

        public override void Setup()
        {
        }

        public override void Execute(Report reporte = null)
        {
            var a = "a";
            var b = "b";
            Assert.AreEqual(a, b);
        }

        public override void TearDown()
        {
        }
    }
}
