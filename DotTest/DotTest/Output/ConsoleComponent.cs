using System;
using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.Output
{
    public class ConsoleComponent : IOutputComponent
    {
        public void PrintTestCase(ReportDto dto)
        {
            Console.WriteLine("[" + dto.Result + "] " + dto.Name);
        }

        public void PrintTestSuite(ReportDto dto)
        {
            Console.WriteLine("\n" + dto.FullName + "\n---------------");
        }
    }
}
