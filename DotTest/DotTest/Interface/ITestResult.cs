
namespace DotTest.Interface
{
    public interface ITestResult
    {
        string Print();
        void AddResult(ITestResult testResult);
    }
}
