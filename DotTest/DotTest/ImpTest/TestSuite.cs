using System;
using System.Collections.Generic;
using System.Linq;
using DotTest.Enum;
using DotTest.ImpResult;
using DotTest.Interface;

namespace DotTest.ImpTest
{
    /// <summary> 
    /// Container of user test cases. Allows to store new user test and to excecute them all usabillity
    /// </summary>

    public class TestSuite : ITest
    {
        private readonly List<ITest> _tests;
        public string FullName { get { return Path + "\\" + Name; } }
        public string Name { get; set; }
        private string _path;
        public string Path {
            get { return _path; } 
            set {
                _path = value;
                foreach (var i in _tests)
	            {
                    i.Path = FullName;		
	            }
            }
        }

        public TestSuite(string name)
        {
            _tests = new List<ITest>();
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

        public virtual void Setup(IContext context) { }
        public virtual void TearDown(IContext context) { }

        public void Execute(IContext context, ITestResult resultFull)
        {
            var result = new TestSuiteResult(this);
            resultFull.AddResult(result);
            foreach (var test in _tests)
            {
                try
                {
                    test.Setup(context);


                    test.Execute(context, result);
                }
                catch (AssertException e)
                {
                    result.AddResult(new TestCaseResult(test, ResultType.Fail));
                }
                catch (AssertSuccess e)
                {
                    result.AddResult(new TestCaseResult(test, ResultType.Ok)); 
                }
                catch (Exception e)
                {
                    result.AddResult(new TestCaseResult(test, ResultType.Error));
                }
                finally
                {
                    test.TearDown(context); 
                }
            }
        }

        public void ExecuteByName(string name, IContext context, ITestResult resultFull)
        {
            var result = new TestSuiteResult(this);
            resultFull.AddResult(result);
            foreach (var test in _tests)
            {
                try
                {
                    test.Setup(context);
                    
                    test.ExecuteByName(name, context, result); 
                }
                catch (AssertException e)
                {
                    result.AddResult(new TestCaseResult(test, ResultType.Fail));                   
                }
                catch (AssertSuccess e)
                {
                    result.AddResult(new TestCaseResult(test, ResultType.Ok)); 
                }
                catch (Exception e)
                {
                    result.AddResult(new TestCaseResult(test, ResultType.Error)); 
                }
                finally
                {
                    test.TearDown(context);
                }
            }
        }
    }
}
