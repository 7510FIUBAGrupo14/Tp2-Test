using System.Collections.Generic;

namespace DotTest
{
    public class Report
    {
        public bool ExistErrors { get { return Errors.Count > 0; } }
        
        public List<string> Errors { get; private set; }
        
        public Report()
        {
            Errors = new List<string>();
        }
    }
}
