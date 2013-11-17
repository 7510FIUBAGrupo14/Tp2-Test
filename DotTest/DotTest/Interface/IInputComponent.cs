using System.Collections.Generic;
using DotTest.Dto;

namespace DotTest.Interface
{
    /// <summary> 
    /// Output components Interface. Declares common methods for posible output prints.
    /// </summary>
    /// 
    public interface IInputComponent
    {
        bool SkipeCase(CaseDto dto);
    }
}
