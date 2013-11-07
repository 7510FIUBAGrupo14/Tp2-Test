namespace DotTest.Interface
{
    /// <summary> 
    /// Test Case Interface provided for User usage. All User test cases must implement this interface.
    /// </summary>
    
    public interface IContext
    {
        void Add(string key,object obj);
        void Remove(string key);
        T Get<T>(string key);
        object Get(string key);
    }
}
