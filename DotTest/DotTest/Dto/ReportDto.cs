using System;
using DotTest.Enum;

namespace DotTest.Dto
{
    public class ReportDto
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string FullName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ResultType Result { get; set; }
    }
}
