using System.Collections.Generic;
using System.Xml.Linq;
using DotTest.Dto;
using DotTest.Enum;

namespace DotTest.Output.Xml
{
    /// <summary> 
    /// XML Node for test Case. For XML output, gathers the node information of a specific case test. 
    /// </summary>
    
    public class XmlCase : IXmlNode
    {
        private Queue<string> paths;
        public string Name { get; private set; }
        public Dictionary<string, string> Attributes { get; set; }
        public Dictionary<string, double> GeneralAttributes { get; set; }

        public XmlCase(CaseDto report)
        {
            paths = new Queue<string>();
            Attributes = new Dictionary<string, string>();
            GeneralAttributes = new Dictionary<string, double>();

            Name = report.Name;
            Attributes["name"] = report.Name;
            Attributes["skipped"] = report.Skiped.ToString();
            Attributes["resultType"] = report.ResultType;
            Attributes["resultMessage"] = report.ResultMessage;
            GeneralAttributes["failures"] = report.Result == ResultType.Fail ? 1 : 0;
            GeneralAttributes["errors"] = report.Result == ResultType.Error ? 1 : 0;
            GeneralAttributes["time"] = (report.EndTime - report.StartTime).TotalMinutes;

            foreach (var path in report.Path.Split('/'))
            {
                paths.Enqueue(path);
            }
        }
        public void AddNode(IXmlNode node)
        {
            throw new System.NotImplementedException();
        }

        public string GetFatherName()
        {
            try
            {
                return paths.Dequeue();
            }
            catch
            {
                return null;
            }
        }

        public XElement Print()
        {
            var r =  new XElement("testCase",
                                 new XAttribute("name", Name),
                                 new XAttribute("failures", GeneralAttributes["failures"].ToString()),
                                 new XAttribute("errors", GeneralAttributes["errors"].ToString()),
                                 new XAttribute("time", GeneralAttributes["time"].ToString()),
                                 new XElement("skipped", Attributes["skipped"]));

            if (GeneralAttributes["errors"] == 1)
            {
                r.Add(new XElement("error", new XAttribute("Type", Attributes["resultType"]),
                                                       new XAttribute("Message", Attributes["resultMessage"])));
            }
            if (GeneralAttributes["failures"] == 1)
            {
                r.Add(new XElement("failure", new XAttribute("Type", Attributes["resultType"]),
                                                       new XAttribute("Message", Attributes["resultMessage"])));
            }
            return r;
        }
    }
}
