
namespace DotTest.Interface
{
    public interface ITestResult
    {
        string Print();
        string PrintSummary();
        void AddResult(ITestResult testResult);

        int OkCount();
        int ErrorCount();
        int FailureCount();
    }
}
