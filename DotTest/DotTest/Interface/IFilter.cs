
using DotTest.Dto;

namespace DotTest.Interface
{
    /// <summary> 
    /// Filter Interface. 
    /// </summary>
    
    public interface IFilter
    {
        bool Skip(CaseDto test);
        bool Skip(SuiteDto test);
    }
}
