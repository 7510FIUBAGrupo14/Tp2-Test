using System.Collections.Generic;

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
        bool Skip { get; set; }
        bool Filterable { get; }
        IEnumerable<string> Tags { get; }
        void Setup(IContext context);
        void Execute(IContext context);
        void TearDown(IContext context);

        void Run(IContext context, IOutputComponent comand, IFilter filter = null);
        

        bool AddTest(ITest test);
    }
}
