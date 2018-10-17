using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Greedy
{
    public class TaskSchedulerCPU
    {
        public int FindMinCycles(char[] tasks, int gap)
        {
            var taskCounts = new int[26];
            foreach (var task in tasks)
            {
                taskCounts[task - 'A']++;
            }

            Array.Sort(taskCounts);

            //var taskOrder = new List<char>();

            var time = 0;

            while (taskCounts[25] > 0)
            {
                var i = 0;
                while (i <= gap)
                {
                    if (taskCounts[25] == 0)
                        break;

                    if (i < 26 && taskCounts[25 - i] > 0)
                    {
                        //taskOrder.Add((char)('A' + i));
                        taskCounts[25 - i]--;
                    }
                    else
                    {
                        //taskOrder.Add(' ');
                    }

                    i++;
                    time++;
                }
                Array.Sort(taskCounts);
            }

            return time;
        }

        public int FindMinCyclesUsingHeap(char[] tasks, int gap)
        {
            var taskCounts = new int[26];
            foreach (var task in tasks)
            {
                taskCounts[task - 'A']++;
            }

            Array.Sort(taskCounts);

            var time = 0;

            while (taskCounts[25] > 0)
            {
                var i = 0;
                while (i <= gap)
                {
                    if (taskCounts[25] == 0)
                        break;

                    if (i < 26 && taskCounts[25 - i] > 0)
                    {
                        //taskOrder.Add((char)('A' + i));
                        taskCounts[25 - i]--;
                    }
                    else
                    {
                        //taskOrder.Add(' ');
                    }

                    i++;
                    time++;
                }
                Array.Sort(taskCounts);
            }

            return time;
        }
    }
}
