
namespace DotTest.Interface
{
    /// <summary> 
    /// Filter Interface. 
    /// </summary>
    
    public interface IFilter
    {
        bool Skip(ITest test);
    }
}
