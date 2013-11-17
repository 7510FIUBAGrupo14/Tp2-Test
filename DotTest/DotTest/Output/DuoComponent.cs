using System;
using System.IO;
using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.Output
{
    /// <summary> 
    /// Prints both on console and plain file all tests' run.
    /// </summary>
    
    public class DuoComponent : IInpOutComponent
    {
        private ConsoleComponent _console;
        private StoreFileComponent _file;
        public DuoComponent()
        {
            _console = new ConsoleComponent();
            _file = new StoreFileComponent();
        }
        public void PrintTestCase(CaseDto dto)
        {
            _console.PrintTestCase(dto);
            _file.PrintTestCase(dto);
        }

        public void PrintTestSuite(SuiteDto dto)
        {
            _console.PrintTestSuite(dto);
            _file.PrintTestSuite(dto);
        }

        public void PrintSummary()
        {
            _console.PrintSummary();
            _file.PrintSummary();
        }

        public bool SkipeCase(CaseDto dto)
        {
            return _file.SkipeCase(dto);
        }

    }
}
