namespace DotTest.Interface
{
    /// <summary> 
    /// Interface defining fixture usabilty. 
    /// </summary>
    
    public interface IContext
    {
        void Add(string key,object obj);
        void Remove(string key);
        T Get<T>(string key);
        object Get(string key);
    }
}
