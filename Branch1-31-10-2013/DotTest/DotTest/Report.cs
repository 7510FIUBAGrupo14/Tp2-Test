using System.Collections.Generic;

namespace DotTest
{
    /// <summary> 
    /// Stores test messages from test case excecutions performed by the Test container 
    /// </summary>
    
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
