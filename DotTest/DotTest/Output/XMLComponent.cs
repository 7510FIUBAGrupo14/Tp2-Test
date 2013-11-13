using System.Xml.Linq;
using DotTest.Dto;
using DotTest.Interface;
using DotTest.Output.Xml;

namespace DotTest.Output
{
    public class XmlComponent : IOutputComponent
    {
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
            var bla = new XDocument(aaa);
        }

        public XmlComponent()
        {
            testRoot = new XmlRoot();
        }

    }
}
