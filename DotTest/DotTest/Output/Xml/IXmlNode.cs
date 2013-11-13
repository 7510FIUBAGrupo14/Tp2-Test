using System.Collections.Generic;
using System.Xml.Linq;

namespace DotTest.Output.Xml
{
    public interface IXmlNode
    {
        string Name { get;}
        Dictionary<string, string> Attributes { get; set; }
        Dictionary<string, double> GeneralAttributes { get; set; }

        void AddNode(IXmlNode node);
        string GetFatherName();

        XElement Print();
    }
}
