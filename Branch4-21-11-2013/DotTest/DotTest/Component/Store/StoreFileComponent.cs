using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DotTest.Dto;
using DotTest.Enum;
using DotTest.Interface;

namespace DotTest.Component.Store
{
    /// <summary> 
    /// Prints on plain file all tests' run.
    /// </summary>
    
    public class StoreFileComponent : IInpOutComponent
    {
        private string _fileName;

        public void PrintTestCase(CaseDto dto)
        {
            if (dto.Result == ResultType.Ok)
            {
                Print(dto.FullName);   
            }
        }

        public void PrintTestSuite(SuiteDto dto)
        {
        }

        public void PrintSummary()
        {
        }

        public bool SkipeCase(CaseDto dto)
        {
            if (!File.Exists(_fileName)) return false;
            var fileS = new StreamReader(_fileName);
            var list = new List<string>();
            while (!fileS.EndOfStream)
            {
                list.Add(fileS.ReadLine());
            }

            fileS.Close();
            return list.Any( x => x == dto.FullName);
        }

        public StoreFileComponent()
        {
            var currentDir = Environment.CurrentDirectory;
            var directory = new DirectoryInfo(currentDir);
            _fileName = directory.FullName + "/StoreFile";
        }

        private void Print(string str)
        {
            var fileS = new StreamWriter(_fileName,true);
            fileS.WriteLine(str);
            fileS.Close();
        }

    }
}
