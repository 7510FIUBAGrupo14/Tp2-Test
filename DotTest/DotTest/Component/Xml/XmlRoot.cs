using System.Collections.Generic;
using System.Xml.Linq;

namespace DotTest.Component.Xml
{
    /// <summary> 
    /// XML Root Node. For XML output, summarize information on root node. 
    /// </summary>
    
    public class XmlRoot : IXmlNode
    {
        private IXmlNode root;
        public string Name { get; private set; }
        public Dictionary<string, string> Attributes { get; set; }
        public Dictionary<string, double> GeneralAttributes { get; set; }

        public void AddNode(IXmlNode node)
        {
            var father = node.GetFatherName();
            if (father == null)
            {
                root = node;
            }
            else{
                root.AddNode(node);
            }
        }

        public string GetFatherName()
        {
            return "";
        }

        public XElement Print()
        {
            return root.Print();
        }
    }
}
