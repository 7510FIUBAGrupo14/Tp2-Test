
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DotTest.Interface;

namespace DotTest.ImpTest
{
    /// <summary> 
    /// capability of adding tags on test. It has decision to skip a test.
    /// </summary>
    
    public class Filter : IFilter
    {
        private string _nameCase;
        private string _nameSuit;
        private IEnumerable<string> _tags; 
        public Filter(string nameCase, string nameSuit, IEnumerable<string> tags = null)
        {
            _nameCase = nameCase ?? "";
            _nameSuit = nameSuit ?? "";
            _tags = tags != null ? new List<string>(tags) : new List<string>();
        }
        public Filter(string nameCase, IEnumerable<string> tags = null)
        {
            _nameCase = nameCase ?? "";
            _nameSuit = "";
            _tags = tags != null ? new List<string>(tags) : new List<string>();
        }
        public Filter(IEnumerable<string> tags)
        {
            _nameCase = "";
            _nameSuit = "";
            _tags = new List<string>(tags);
        }
        public bool Skip(ITest test)
        {
            if (!test.Filterable) return false;
            var name = _nameCase;
            if (test.GetType() == typeof (TestSuite))
            {
                name = _nameSuit;
                var match = Regex.Match(test.Name, name).Length > 0;
                return test.Skip || (!match && name != "");
            }

            var match1 = Regex.Match(test.Name, name).Length > 0;
            return test.Skip || (!match1 && name != "") || (_tags.Any() && !test.Tags.Any( x => _tags.Any(y => y.Contains(x))));
        }
    }
}
