
namespace DotTest.Interface
{
    public interface ITestResult
    {
       /* int Runs { get; set; }
        int Errors { get; set; }
        int Failures { get; set; }*/

        string Print();
        void AddResult(ITestResult testResult);
        //void Initialize();
        int OkCount();
        int ErrorCount();
        int FailureCount();
    }
}
