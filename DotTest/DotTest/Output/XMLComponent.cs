using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using DotTest.Dto;
using DotTest.Enum;
using DotTest.Interface;

namespace DotTest.Output
{
    public class XMLComponent : IOutputComponent
    {
        private string _fileName;
        private XDocument miXML;
        private XElement suites;
        private int _errorCount;
        private int _failureCount;
        private int _okCount;

        public void PrintTestCase(ReportDto dto)
        {
            var paths = dto.Path.Split('/');
            var aux = paths.Aggregate(suites, (current, nombre) => current.Elements("testSuite").FirstOrDefault(x => x.Attribute("name").Value == nombre));

            aux.Add(new XElement("testCase",
                new XAttribute("name", dto.Name),
                new XAttribute("failures", dto.Result == ResultType.Fail ? 1 : 0),
                new XAttribute("errors", dto.Result == ResultType.Error ? 1 : 0),
                new XAttribute("time", (dto.EndTime - dto.StartTime).TotalMinutes),
                new XAttribute("skipped", dto.Skiped)
            ));

            aux.Attribute("failures").Value = (int.Parse(aux.Attribute("failures").Value) + (dto.Result == ResultType.Fail ? 1 : 0)).ToString();
            aux.Attribute("errors").Value = (int.Parse(aux.Attribute("errors").Value) + (dto.Result == ResultType.Error ? 1 : 0)).ToString();
            aux.Attribute("time").Value = (float.Parse(aux.Attribute("time").Value) + (dto.EndTime - dto.StartTime).TotalMinutes).ToString();
            if (dto.Result == ResultType.Error) _errorCount++;
            if (dto.Result == ResultType.Fail) _failureCount++;
            if (dto.Result == ResultType.Ok) _okCount++;
        }

        public void PrintTestSuite(ReportDto dto)
        {
            var element = new XElement("testSuite",
                         new XAttribute("name", dto.Name),
                         new XAttribute("failures", "0"),
                         new XAttribute("errors", "0"),
                         new XAttribute("time", "0"),
                         new XAttribute("skipped", dto.Skiped));

            if (dto.Path == null)
            {
                suites.Add(element);
            }
            else
            {
                var paths = dto.Path.Split('/');
                var aux = paths.Aggregate(suites, (current, nombre) => current.Elements("testSuite").FirstOrDefault(x => x.Attribute("name").Value == nombre));
                aux.Add(element);
            }
        }

        public void PrintSummary()
        {
            //var result = _errorCount == 0 && _failureCount == 0 ? "[success]" : "[failure]";
            //var ret = "\n" + result + "Summary\n=====================\n";
            //ret += "Run: " + (_okCount + _errorCount + _failureCount) + "\n";
            //ret += "Ok: " + _okCount + "\n";
            //ret += "Errors: " + _errorCount + "\n";
            //ret += "Failures: " + _failureCount + "\n";

        }

        public XMLComponent()
        {
            var currentDir = Environment.CurrentDirectory;
            var directory = new DirectoryInfo(currentDir);
            _fileName = directory.FullName + "\\XMLTestReport_" + DateTime.Now.ToFileTime();

            suites = new XElement("testsuites",
                                  new XAttribute("name", "Runner"),
                                  new XAttribute("time", "0"));
            miXML = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), suites);
        }

        private void Print(string str)
        {
            var fileS = new StreamWriter(_fileName,true);
            fileS.WriteLine(str);
            fileS.Close();
        }

    }
}
