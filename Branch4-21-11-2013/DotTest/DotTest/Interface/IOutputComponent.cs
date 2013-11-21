using System.Collections.Generic;
using DotTest.Dto;

namespace DotTest.Interface
{
    /// <summary> 
    /// Output components Interface. Declares common methods for posible output prints.
    /// </summary>
    /// 
    public interface IOutputComponent
    {
        void PrintTestCase(CaseDto dto);
        void PrintTestSuite(SuiteDto dto);
        void PrintSummary();
    }
}
