using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.Component
{
    /// <summary> 
    /// Prints both on console and plain file all tests' run.
    /// </summary>
    
    public class MockComponent : IInpOutComponent
    {
  
        public void PrintTestCase(CaseDto dto)
        {
        }

        public void PrintTestSuite(SuiteDto dto)
        {
        }

        public void PrintSummary()
        {
        }

        public bool SkipeCase(CaseDto dto)
        {
            return false;
        }
    }
}
