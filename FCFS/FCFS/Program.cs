using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // memory block

            List<Process> processes = new List<Process> {
                new Process { Id = 1, Size = 120 },
                new Process { Id = 2, Size = 80 }
                };

            var blocks = new List<MemoryBlock>
            {
                new MemoryBlock { Id = 1, Size = 100 },
                new MemoryBlock { Id = 2, Size = 500 },
                new MemoryBlock { Id = 3, Size = 200 }
            };

            MemoryManager memoryManager = new MemoryManager(blocks);

            memoryManager.FirstComeFirstServed(processes);

        }
    }
}
