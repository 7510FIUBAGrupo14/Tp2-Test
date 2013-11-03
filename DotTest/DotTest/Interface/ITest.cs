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
        void Setup();
        void Execute(Report reporte = null);
        void TearDown();

        void AddTest(ITest test);
    }
}
