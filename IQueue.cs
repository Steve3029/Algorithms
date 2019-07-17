using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    interface IQueue
    {
        void Add(int value);
        int Remove();
        bool IsEmpty { get; }
        int Size();
    }
}
