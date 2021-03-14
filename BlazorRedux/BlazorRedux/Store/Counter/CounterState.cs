using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRedux.Store.Counter
{
    public class CounterState
    {
        public int CurrentCount { get; }

        public CounterState(int currentCount)
        {
            CurrentCount = currentCount;
        }
    }
}
