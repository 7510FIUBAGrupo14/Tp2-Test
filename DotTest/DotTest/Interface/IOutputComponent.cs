using DotTest.Dto;

namespace DotTest.Interface
{
    /// <summary> 
    /// Output components Interface. Declares common methods for posible output prints.
    /// </summary>
    /// 
    public interface IOutputComponent
    {
        void PrintTestCase(ReportDto dto);
        void PrintTestSuite(ReportDto dto);
        void PrintSummary();
    }
}
