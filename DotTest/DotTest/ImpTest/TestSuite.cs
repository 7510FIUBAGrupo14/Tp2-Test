using System;
using System.Collections.Generic;
using System.Linq;
using DotTest.Dto;
using DotTest.Interface;

namespace DotTest.ImpTest
{
    /// <summary> 
    /// Container of user test cases. Allows to store new user test and to excecute them all usabillity
    /// </summary>
    public class TestSuite : ITest
    {
        private readonly List<ITest> _tests;

        public string FullName
        {
            get { return (!String.IsNullOrEmpty(Path) ? (Path + "/") : "") + Name; }
        }

        public string Name { get; set; }
        private string _path;

        public string Path
        {
            get { return _path; }
            set
            {
                _path = value;
                foreach (var i in _tests)
                {
                    i.Path = FullName;
                }
            }
        }

        public bool Skip { get; set; }
        public bool Filterable { get; private set; }
        public IEnumerable<string> Tags { get; private set; }

        public TestSuite(string name, bool filtrable = true)
        {
            _tests = new List<ITest>();
            Tags = new List<string>();
            Filterable = filtrable;
            Name = name;
        }

        public bool AddTest(ITest test)
        {
            if (_tests.All(x => x.Name != test.Name))
            {
                test.Path = FullName;
                _tests.Add(test);
                return true;
            }
            return false;
        }

        public virtual void Setup(IContext context)
        {
        }

        public virtual void TearDown(IContext context)
        {
        }

        public void Execute(IContext context)
        {
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
            component.PrintTestSuite(dto);

            Setup(context);
            foreach (var test in _tests)
            {
                test.Run(context, component, filter);
            }
            TearDown(context);
        }
    }
}