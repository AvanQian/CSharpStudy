using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;


namespace MultiThreadsExample
{
    class ThreadWork1
    {
        public ConcurrentDictionary<int, string> _concurrentDictionary = new ConcurrentDictionary<int,string>();

        public ThreadWork1()
        { }

        public void run()
        {
            for (int i = 0; i < 100; i++)
            {
                string localValue = string.Format("ThreadWork1_{0}", i);
                _concurrentDictionary.TryAdd(i, localValue);
            }
        }
    }

    class ThreadWork2
    {
        public ConcurrentDictionary<int, string> _concurrentDictionary = new ConcurrentDictionary<int, string>();

        public ThreadWork2()
        { }

        public void run()
        {
            for (int i = 0; i < 100; i++)
            {
                string localValue = string.Format("ThreadWork2_{0}", i);
                _concurrentDictionary.TryAdd(i, localValue);
            }
        }
    }
}
