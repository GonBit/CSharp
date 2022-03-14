using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedNUnit
{
    public class Counter
    {
        public int Count { get; private set; }
        public Counter(int start) { Count = start; }
        public void Increment() { Count++; }
        public void Decrement() { Count--; }
    }
}
