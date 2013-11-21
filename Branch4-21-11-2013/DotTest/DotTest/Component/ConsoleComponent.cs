﻿using System;
using DotTest.Dto;
using DotTest.Enum;
using DotTest.Interface;

namespace DotTest.Component
{
    /// <summary> 
    /// Prints on console all tests' run.
    /// </summary>
    
    public class ConsoleComponent : IInpOutComponent
    {
        private int _errorCount;
        private int _failureCount;
        private int _okCount;

        public void PrintTestCase(CaseDto dto)
        {
            Console.WriteLine("[" + dto.Result + "] " + dto.Name);
            if (dto.Result == ResultType.Error) _errorCount++;
            if (dto.Result == ResultType.Fail) _failureCount++;
            if (dto.Result == ResultType.Ok) _okCount++;
        }

        public void PrintTestSuite(SuiteDto dto)
        {
            Console.WriteLine("\n" + dto.FullName + "\n---------------");
        }

        public void PrintSummary()
        {
            var result = _errorCount == 0 && _failureCount == 0 ? "[success]" : "[failure]";
            var ret = "\n" + result + "Summary\n=====================\n";
            ret += "Run: " + (_okCount + _errorCount + _failureCount) + "\n";
            ret += "Ok: " + _okCount + "\n";
            ret += "Errors: " + _errorCount + "\n";
            ret += "Failures: " + _failureCount + "\n";
            Console.WriteLine(ret);
        }

        public bool SkipeCase(CaseDto dto)
        {
            return false;
        }
    }
}
