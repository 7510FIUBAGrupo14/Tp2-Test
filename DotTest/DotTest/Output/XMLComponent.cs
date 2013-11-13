using System;
using System.IO;
using System.Xml.Linq;
using DotTest.Dto;
using DotTest.Interface;
using DotTest.Output.Xml;

namespace DotTest.Output
{
    public class XmlComponent : IOutputComponent
    {
        private string _fileName;
        private XmlRoot testRoot;
        public void PrintTestCase(ReportDto dto)
        {
            testRoot.AddNode(new XmlCase(dto));
        }

        public void PrintTestSuite(ReportDto dto)
        {
            testRoot.AddNode(new XmlSuite(dto));            
        }

        public void PrintSummary()
        {
            var aaa = testRoot.Print();
            Print(new XDocument(aaa).ToString());
        }

        public XmlComponent()
        {
            var currentDir = Environment.CurrentDirectory;
            var directory = new DirectoryInfo(currentDir);
            testRoot = new XmlRoot();
            _fileName = directory.FullName + "/XmlTestReport_" + DateTime.Now.ToFileTime();
        }

        private void Print(string str)
        {
            var fileS = new StreamWriter(_fileName, false);
            fileS.Write(str);
            fileS.Close();
        }

    }
}
