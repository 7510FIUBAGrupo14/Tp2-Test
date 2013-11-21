
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using DotTest.Dto;
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
        private IInputComponent _component;
        public Filter(string nameCase, string nameSuit, IEnumerable<string> tags = null, IInputComponent component = null)
        {
            _nameCase = nameCase ?? "";
            _nameSuit = nameSuit ?? "";
            _tags = tags != null ? new List<string>(tags) : new List<string>();
            _component = component;
        }
        public Filter(string nameCase, IEnumerable<string> tags = null, IInputComponent component = null)
        {
            _nameCase = nameCase ?? "";
            _nameSuit = "";
            _tags = tags != null ? new List<string>(tags) : new List<string>();
            _component = component;
        }
        public Filter(IEnumerable<string> tags, IInputComponent component = null)
        {
            _nameCase = "";
            _nameSuit = "";
            _tags = new List<string>(tags);
            _component = component;
        }

        public Filter(IInputComponent component = null)
        {
            _nameCase = "";
            _nameSuit = "";
            _tags = new List<string>();
            _component = component;
        }

        public bool Skip(CaseDto test)
        {
            if (!test.Filterable) return false;
            if (_component != null && _component.SkipeCase(test)) return true;

            var match1 = Regex.Match(test.Name, _nameCase).Length > 0;
            return test.Skiped || (!match1 && _nameCase != "") || (_tags.Any() && !test.Tags.Any(x => _tags.Any(y => y.Contains(x))));
        }

        public bool Skip(SuiteDto test)
        {
            if (!test.Filterable) return false;

            var match = Regex.Match(test.Name, _nameSuit).Length > 0;
            return test.Skiped || (!match && _nameSuit != "");

        }
    }
}
