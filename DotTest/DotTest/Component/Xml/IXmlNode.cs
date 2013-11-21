using System.Collections.Generic;
using System.Xml.Linq;

namespace DotTest.Component.Xml
{
    /// <summary> 
    /// XML Node Interface. For XML output, gathers the node information of a specific test. 
    /// </summary>
    
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
