using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.DynamicProgramming
{
    public class LongestRepeatedSubsequence
    {
        public static string Find(string input)
        {
            var max = new int[Int32.MaxValue/2^20];
            if (string.IsNullOrEmpty(input)) return null;

            var original = input;
            var copy = (string)original.Clone();

            var memory = new int[input.Length + 1, copy.Length + 1];
            var printMemory = new int[input.Length + 1, copy.Length + 1];

            // Fill up first row.
            for (var k = 1; k <= copy.Length; k++)
                memory[0, k] = 0;

            // Fill up left column
            for (var k = 1; k <= input.Length; k++)
                memory[k, 0] = 0;

            for (var i = 1; i <= input.Length; i++)
            {
                for (var j = 1; j <= copy.Length; j++)
                {
                    if (input[i - 1] == copy[j - 1] && i != j)
                    {
                        printMemory[i, j] = 1;
                        memory[i, j] = 1 + memory[i - 1, j - 1];
                    }
                    else
                    {
                        memory[i, j] = Math.Max(memory[i - 1, j], memory[i, j - 1]);
                    }
                }
            }

            var test = memory[input.Length, copy.Length];
            return "";
        }
    }
}
