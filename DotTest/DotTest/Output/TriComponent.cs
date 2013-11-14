using System;
using System.IO;
using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.Output
{
    /// <summary> 
    /// Prints both on console and plain file all tests' run.
    /// </summary>
    
    public class TriComponent : IOutputComponent
    {
        private ConsoleComponent _console;
        private FileComponent _file;
        private XmlComponent _xml;
        public TriComponent()
        {
            _console = new ConsoleComponent();
            _file = new FileComponent();
            _xml = new XmlComponent();
        }
        public void PrintTestCase(ReportDto dto)
        {
            _console.PrintTestCase(dto);
            _file.PrintTestCase(dto);
            _xml.PrintTestCase(dto);
        }

        public void PrintTestSuite(ReportDto dto)
        {
            _console.PrintTestSuite(dto);
            _file.PrintTestSuite(dto);
            _xml.PrintTestSuite(dto);
        }

        public void PrintSummary()
        {
            _console.PrintSummary();
            _file.PrintSummary();
            _xml.PrintSummary();
        }

    }
}
