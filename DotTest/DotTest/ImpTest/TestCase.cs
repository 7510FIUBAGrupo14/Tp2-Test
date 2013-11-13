using System;
using System.Collections.Generic;
using DotTest.Dto;
using DotTest.Enum;
using DotTest.Interface;
using System.Text.RegularExpressions;

namespace DotTest.ImpTest
{
    public abstract class TestCase : ITest
    {
        public string FullName { get { return (Path != "" ? (Path + "/") : "") + Name; } }
        public string Name { get; private set; }
        public string Path { get; set; }
        public bool Skip { get; set; }
        public bool Filterable { get; private set; }
        public IEnumerable<string> Tags { get; private set; }
        public abstract void Setup(IContext context);
        public abstract void Execute(IContext context);
        public abstract void TearDown(IContext context);

        protected TestCase(string name, IEnumerable<string> tags, bool filterable = true)
        {
            Name = name;
            Tags = new List<string>(tags);
            Filterable = filterable;
        }

        public void Run(IContext context, IOutputComponent component, IFilter filter = null)
        {
            if (filter != null && filter.Skip(this)) return;

            var dto = new ReportDto
                {
                    Name = Name,
                    Path = Path,
                    FullName = FullName,
                    StartTime = DateTime.Now,
                    Skiped = Skip
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

        public bool AddTest(ITest test)
        {
            return false;
        }
    }
}
