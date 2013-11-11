using DotTest.Dto;

namespace DotTest.Interface
{
    public interface IOutputComponent
    {
        void PrintTestCase(ReportDto dto);
        void PrintTestSuite(ReportDto dto);
        void PrintSummary();
    }
}
