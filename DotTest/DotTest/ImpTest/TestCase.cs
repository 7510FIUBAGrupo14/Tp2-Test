
using DotTest.Interface;
using System.Text.RegularExpressions;

namespace DotTest.ImpTest
{
    public abstract class TestCase : ITest
    {
        public string FullName { get{ return Path + "\\" + Name;} }
        public string Name { get; private set; }
        public string Path { get; set; }
        public abstract void Setup();
        public abstract void Execute(ITestResult reporte = null);
        public abstract void TearDown();

        public virtual void ExecuteByName(string name, ITestResult reporte) 
        {
            Match match = Regex.Match(Name, name); //
            if (match.Success){
                Execute(reporte);
            }
        }

        protected TestCase(string name)
        {
            Name = name;
        }
        
        public bool AddTest(ITest test)
        {
            return false;
        }
    }
}
