using System;
using System.Collections.Generic;
using DotTest.Enum;
using DotTest.ImpTest;

namespace DotTest.Dto
{
    /// <summary> 
    /// To be used to get test result. This clase may return ReportDto for case or suite test depending on type of test.
    /// </summary>
 
    public class CaseDto
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FullName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ResultType Result { get; set; }
        public bool Skiped { get; set; }
        public bool Filterable { get; set; }
        public string ResultType { get; set; }
        public string ResultMessage { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}
