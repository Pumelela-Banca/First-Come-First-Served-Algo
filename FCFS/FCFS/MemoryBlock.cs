using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    internal class MemoryBlock
    {
        public int  Id { get; set;  }
        public int Size { get; set; }
        public bool IsFree { get; set; }
        public int? ProcessId { get; set; }

    }
}
