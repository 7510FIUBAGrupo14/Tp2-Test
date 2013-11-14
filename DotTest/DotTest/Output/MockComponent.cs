using System;
using System.IO;
using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.Output
{
    /// <summary> 
    /// Prints both on console and plain file all tests' run.
    /// </summary>
    
    public class MockComponent : IOutputComponent
    {
  
        public void PrintTestCase(ReportDto dto)
        {
        }

        public void PrintTestSuite(ReportDto dto)
        {
        }

        public void PrintSummary()
        {
        }

    }
}
