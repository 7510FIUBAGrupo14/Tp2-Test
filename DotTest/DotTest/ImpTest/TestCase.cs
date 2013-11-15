using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DotTest.Dto;
using DotTest.Enum;
using DotTest.Interface;
using System.Text.RegularExpressions;

namespace DotTest.ImpTest
{
    /// <summary> 
    /// Test Case provided for User usage. All User's test cases must implement this class.
    /// </summary>
    
    public abstract class TestCase : ITest
    {
        public string FullName { get { return (Path != "" ? (Path + "/") : "") + Name; } }
        public string Name { get; private set; }
        public string Path { get; set; }
        public int TimeOut { get; set; }
        public bool Skip { get; set; }
        public bool Filterable { get; private set; }
        public IEnumerable<string> Tags { get; private set; }
        public abstract void Setup(IContext context);
        public abstract void Execute(IContext context);
        public abstract void TearDown(IContext context);

        protected TestCase(string name, IEnumerable<string> tags, int timeOut = 0, bool filterable = true)
        {
            Name = name;
            Tags = new List<string>(tags);
            Filterable = filterable;
            TimeOut = timeOut;
        }

        public void Run(IContext context, IOutputComponent component, IFilter filter = null)
        {
            if (filter != null && filter.Skip(this)) return;

            var dto = ReportDto.FromTestCaseFactory(this);

            Setup(context);
            try
            {
                if (TimeOut > 0)
                {
                    TryExecute(Execute, context, TimeOut);
                }
                else
                {
                    Execute(context);
                }
            }
            catch (AssertException e)
            {
                dto.Result = ResultType.Fail;
                dto.ResultType = e.GetType().ToString().Split('.').Last();
                dto.ResultMessage = e.Message;
            }
            catch (AssertSuccess e)
            {
                dto.Result = ResultType.Ok;
                dto.ResultType = e.GetType().ToString().Split('.').Last();
                dto.ResultMessage = e.Message;
            }
            catch (Exception e)
            {
                dto.Result = ResultType.Error;
                dto.ResultType = e.GetType().ToString().Split('.').Last();
                dto.ResultMessage = e.Message;
            }
            finally
            {
                TearDown(context);
                dto.EndTime = DateTime.Now;
            }
            component.PrintTestCase(dto);
        }

        public bool AddTest(ITest test)
        {
            return false;
        }

        private static void TryExecute(Action<IContext> func, IContext context, int timeout)
        {
            var thread = new Thread(() => func(context));
            thread.Start();
            var completed = thread.Join(timeout);
            if (!completed)
            {
                thread.Abort();
                throw new AssertException("Time Out");
            }
        }
    }
}
