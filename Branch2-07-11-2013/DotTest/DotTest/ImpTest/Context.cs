using DotTest.Interface;
using System.Collections.Generic;

namespace DotTest.ImpTest
{
    public class Context : IContext
    {
        private Dictionary<string, object> fixture;

        public Context()
        {
            fixture = new Dictionary<string, object>();
        }
        public void Add(string key, object obj)
        {
            if (fixture.ContainsKey(key))
            {
                fixture.Remove(key);
            }
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

        public object Get(string key)
        {
            return !fixture.ContainsKey(key) ? null : fixture[key];
        }
    }
}
