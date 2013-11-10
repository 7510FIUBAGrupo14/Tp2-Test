using System;
using System.IO;
using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.Output
{
    public class FileComponent : IOutputComponent
    {
        private string _fileName;
        public FileComponent()
        {
            var currentDir = Environment.CurrentDirectory;
            var directory = new DirectoryInfo(currentDir);
            _fileName = directory.FullName + "\\TestReport_" + DateTime.Now.ToFileTime();
        }
        public void PrintTestCase(ReportDto dto)
        {
            Print("[" + dto.Result + "] " + dto.Name);
        }

        public void PrintTestSuite(ReportDto dto)
        {
            Print("\n" + dto.FullName + "\n---------------");
        }

        private void Print(string str)
        {
            var fileS = new StreamWriter(_fileName,true);
            fileS.WriteLine(str);
            fileS.Close();
        }

    }
}
