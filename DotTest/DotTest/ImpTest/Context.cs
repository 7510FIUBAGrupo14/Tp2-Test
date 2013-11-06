using DotTest.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotTest.ImpTest
{
    class Context : IContext
    {
        private Dictionary<string, object> fixture;

        public Context()
        {
            fixture = new Dictionary<string, object>();
        }
        public void Add(string key, object obj)
        {
            fixture.Add(key, obj);
        }

        public void Remove(string key)
        {
            fixture.Remove(key);
        }

        public T Get<T>(string key)
        {
            return (T)fixture[key];
        }

    }
}
