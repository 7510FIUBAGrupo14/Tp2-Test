
using System.Collections.Generic;
using DotTest.Dto;

namespace DotTest.ImpTest
{
    public static class Factory
    {
        public static CaseDto CaseDto(TestCase cases)
        {
            return new CaseDto
            {
                Name = cases.Name,
                Path = cases.Path,
                FullName = cases.FullName,
                Filterable = cases.Filterable,
                Skiped = cases.Skip,
                Tags = new List<string> (cases.Tags)
            };
        }

        public static SuiteDto SuiteDto(TestSuite suite)
        {
            return new SuiteDto
            {
                Name = suite.Name,
                Path = suite.Path,
                FullName = suite.FullName,
                Filterable = suite.Filterable,
                Skiped = suite.Skip
            };
        }
    }
}
