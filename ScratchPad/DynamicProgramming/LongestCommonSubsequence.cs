using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    public class LCSHelpers
    {
        /// <summary>
        /// This is the DP Version of LCS Problem's Solution. (Tabulation - BottomUp)
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        public static void LCS(string firstString, string secondString)
        {
            var start = DateTime.UtcNow.Millisecond;

            if (string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString)) return;

            var memory = new int[firstString.Length+1, secondString.Length+1];
            var printMemory = new int[firstString.Length + 1, secondString.Length + 1];

            for (var k = 1; k <= firstString.Length; k++)
                memory[k, 0] = 0;

            for (var k = 1; k <= secondString.Length; k++)
                memory[0, k] = 0;

            for (var i = 1; i <= firstString.Length; i++)
            {
                for (var j = 1; j <= secondString.Length; j++)
                {
                    if (firstString[i-1] == secondString[j-1])
                    {
                        printMemory[i, j] = 0; // diagonal
                        memory[i, j] = 1 + memory[i - 1, j - 1];
                    }
                    else if (memory[i - 1, j] >= memory[i, j - 1])
                    {
                        printMemory[i, j] = 1; // Up
                        memory[i, j] = memory[i - 1, j];
                    } else
                    {
                        printMemory[i, j] = 2; // Left
                        memory[i, j] = memory[i, j - 1];
                    }
                }
            }

            PrintLCS(firstString, printMemory, firstString.Length, secondString.Length);
            Console.WriteLine();
            Console.WriteLine("Longest: " + memory[firstString.Length, secondString.Length]);
            var end = DateTime.UtcNow.Millisecond;
            Console.WriteLine("Time Taken: " +  (end - start).ToString() + " ms");
        }

        private static void PrintLCS(string s, int[,] printMemory, int i, int j)
        {
            if (i == 0 || j == 0)
                return;

            if (printMemory[i, j] == 0)
            {
                PrintLCS(s, printMemory, i-1, j-1);
                Console.Write(s[i-1]);
            } else if (printMemory[i, j] == 1)
            {
                PrintLCS(s, printMemory, i - 1, j);
            }
            else
            {
                PrintLCS(s, printMemory, i, j-1);
            }
        }

        public static int Recursive(string a, string b)
        {
           // var start = DateTime.UtcNow.Millisecond;

            for (var i = 1; i <= a.Length; i++)
            {
                for (var j = 1; j <= b.Length; j++)
                {
                    if (a[i - 1] == b[j - 1])
                    {
                        return 1 + Recursive(a.Substring(i), b.Substring(j));
                    }
                    return Math.Max(Recursive(a.Substring(i - 1), b.Substring(j)), Recursive(a.Substring(i), b.Substring(j - 1)));
                }
            }
            return 0;
        }
    }
}
