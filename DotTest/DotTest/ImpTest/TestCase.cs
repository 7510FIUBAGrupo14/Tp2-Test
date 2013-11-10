using System;
using DotTest.Dto;
using DotTest.Enum;
using DotTest.Interface;
using System.Text.RegularExpressions;

namespace DotTest.ImpTest
{
    public abstract class TestCase : ITest
    {
        public string FullName { get{ return Path + "\\" + Name;} }
        public string Name { get; private set; }
        public string Path { get; set; }
        public abstract void Setup(IContext context);
        public abstract void Execute(IContext context);
        public abstract void TearDown(IContext context);

        //public virtual void ExecuteByName(string name, IContext context, ITestResult reporte) 
        //{
        //    var match = Regex.Match(Name, name); 
        //    if (match.Success){
        //        Execute(context, reporte);
        //    }
        //}

        public void Run(IContext context, IOutputComponent component)
        {
            var dto = new ReportDto
                {
                    Name = Name,
                    Path = Path,
                    StartTime = DateTime.Now
                };
            Setup(context);
            try
            {
                Execute(context);
            }
            catch (AssertException)
            {
                dto.Result = ResultType.Fail;
            }
            catch (AssertSuccess)
            {
                dto.Result = ResultType.Ok;
            }
            catch (Exception)
            {
                dto.Result = ResultType.Error;
            }
            finally
            {
                TearDown(context);
                dto.EndTime = DateTime.Now;
            }
            component.PrintTestCase(dto);
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
