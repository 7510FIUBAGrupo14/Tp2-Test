namespace DotTest.Interface
{
    /// <summary> 
    /// Test Case Interface provided for User usage. All User test cases must implement this interface.
    /// </summary>
    
    public interface ITest
    {
        string FullName { get; }
        string Path { get; set; }
        string Name { get; }
        void Setup(IContext context);
        void Execute(IContext context, ITestResult testResult = null);
        void ExecuteByName(string name, IContext context, ITestResult testResult);
        void TearDown(IContext context);

        bool AddTest(ITest test);
    }
}
