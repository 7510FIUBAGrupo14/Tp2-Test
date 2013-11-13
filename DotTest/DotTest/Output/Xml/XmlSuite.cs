using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using DotTest.Dto;

namespace DotTest.Output.Xml
{
    public class XmlSuite : IXmlNode
    {
        private Queue<string> paths;
        private List<IXmlNode> _nodes;
        private string _path;
        public string Name { get; private set; }
        public Dictionary<string, string> Attributes { get; set; }
        public Dictionary<string, double> GeneralAttributes { get; set; }

        public XmlSuite(ReportDto report)
        {
            _nodes = new List<IXmlNode>();
            paths = new Queue<string>();
            Attributes = new Dictionary<string, string>();
            GeneralAttributes = new Dictionary<string, double>();
            Name = report.Name;
            _path = report.Path;
            Attributes["name"] = report.Name;
            Attributes["skipped"] = report.Skiped.ToString();
            if (report.Path != null)
            {
                foreach (var path in report.Path.Split('/'))
                {
                    paths.Enqueue(path);
                }
            }
        }

        public void AddNode(IXmlNode node)
        {
            var father = node.GetFatherName();
            if (father == null)
            {
                _nodes.Add(node);
            }
            else
            {
                var aux = _nodes.First(x => x.Name == father);
                aux.AddNode(node);
            }
            foreach (var key in node.GeneralAttributes.Keys)
            {
                if (GeneralAttributes.ContainsKey(key))
                {
                    GeneralAttributes[key] += node.GeneralAttributes[key];
                }
                else
                {
                    GeneralAttributes[key] = node.GeneralAttributes[key];
                }
            }
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
            var name = _path != null ? "testSuite" : "testSuites";
            var r = new XElement(name,
                                 new XAttribute("name", Name),
                                 new XAttribute("failures", GeneralAttributes["failures"].ToString()),
                                 new XAttribute("errors", GeneralAttributes["errors"].ToString()),
                                 new XAttribute("time", GeneralAttributes["time"].ToString()),
                                 new XAttribute("skipped", Attributes["skipped"]));
            foreach (var xmlNode in _nodes)
            {
                r.Add(xmlNode.Print());
            }
            return r;
        }
    }
}
