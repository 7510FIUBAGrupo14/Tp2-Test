using DotTest.Component.Store;
using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.Component
{
    /// <summary> 
    /// Prints both on console and plain file all tests' run.
    /// </summary>
    
    public class DuoComponent : IInpOutComponent
    {
        private ConsoleComponent _console;
        private StoreDbComponent _file;
        public DuoComponent()
        {
            _console = new ConsoleComponent();
            _file = new StoreDbComponent();
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
