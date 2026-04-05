using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCFS
{
    internal class MemoryManager
    {
        public List<MemoryBlock> Blocks { get; set; }

        public  MemoryManager(List<MemoryBlock> blocks) {
            Blocks = blocks;
        }

        public void FirstComeFirstServed(List<Process> processes)
        {

            foreach (Process process in processes)
            {
                foreach (var block in Blocks)
                {
                    block.IsAllocated = true;
                    block.ProcessId = process.Id;
                    Console.WriteLine("Process {} Allocated to block {}", process.Id, block.Id );
                }
            }
        }
    }
}
