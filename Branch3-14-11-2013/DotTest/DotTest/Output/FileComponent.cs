using System;
using System.IO;
using DotTest.Dto;
using DotTest.Enum;
using DotTest.Interface;

namespace DotTest.Output
{
    /// <summary> 
    /// Prints on plain file all tests' run.
    /// </summary>
    
    public class FileComponent : IOutputComponent
    {
        private string _fileName;
        private int _errorCount;
        private int _failureCount;
        private int _okCount;

        public void PrintTestCase(ReportDto dto)
        {
            Print("[" + dto.Result + "] " + dto.Name);

            if (dto.Result == ResultType.Error) _errorCount++;
            if (dto.Result == ResultType.Fail) _failureCount++;
            if (dto.Result == ResultType.Ok) _okCount++;

        }

        public void PrintTestSuite(ReportDto dto)
        {
            Print("\n" + dto.FullName + "\n---------------");
        }

        public void PrintSummary()
        {
            var result = _errorCount == 0 && _failureCount == 0 ? "[success]" : "[failure]";
            var ret = "\n" + result + "Summary\n=====================\n";
            ret += "Run: " + (_okCount + _errorCount + _failureCount) + "\n";
            ret += "Ok: " + _okCount + "\n";
            ret += "Errors: " + _errorCount + "\n";
            ret += "Failures: " + _failureCount + "\n";
            Print(ret);
        }

        public FileComponent()
        {
            var currentDir = Environment.CurrentDirectory;
            var directory = new DirectoryInfo(currentDir);
            _fileName = directory.FullName + "/TestReport_" + DateTime.Now.ToFileTime();
        }

        private void Print(string str)
        {
            var fileS = new StreamWriter(_fileName,true);
            fileS.WriteLine(str);
            fileS.Close();
        }

    }
}
