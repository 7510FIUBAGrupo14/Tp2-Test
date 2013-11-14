using System;
using System.Collections.Generic;
using DotTest.Enum;
using DotTest.ImpTest;

namespace DotTest.Dto
{
    /// <summary> 
    /// To be used to get test result. This clase may return ReportDto for case or suite test depending on type of test.
    /// </summary>
 
    public class ReportDto
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FullName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ResultType Result { get; set; }
        public bool Skiped { get; set; }
        public string ResultType { get; set; }
        public string ResultMessage { get; set; }   

        private ReportDto(string name, string path, string fullname, bool skiped)
        {
            Name = name;
            Path = path;
            FullName = fullname;
            StartTime = DateTime.Now;
            Skiped = skiped;
        }

        public static ReportDto FromTestSuiteFactory(TestSuite suite)
        {
            return new ReportDto(suite.Name, suite.Path, suite.FullName, suite.Skip);
        }

        public static ReportDto FromTestCaseFactory(TestCase cases)
        {
            return new ReportDto(cases.Name, cases.Path, cases.FullName, cases.Skip);
        }
    }
}
