using System;
namespace ScratchPad.DynamicProgramming
{
    public class KnapSackProblem
    {
        public int FindOptimalWeight(int[] values, int[] weights, int capacity)
        {
            var V = new int[values.Length, capacity + 1];

            for (var r = 0; r < V.GetLength(0); r++)
                for (var c = 0; c < V.GetLength(1); c++)
                    V[r, c] = -1;

            return FindOptimalValue(values, weights, weights.Length - 1, capacity, V);
        }

        public int FindOptimalValue(int[] values, int[] weights, int k, int remaining, int[,] memory){
            if (k < 0)
                return 0;

            if(memory[k, remaining] == -1){
                var withoutIncluding = FindOptimalValue(values, weights, k - 1, remaining, memory);

                var withIncluding = remaining < weights[k] ? 0
                    : values[k] + FindOptimalValue(values, weights, k - 1, remaining - weights[k], memory);

                memory[k, remaining] = Math.Max(withIncluding, withoutIncluding);
            }

            return memory[k, remaining];
        }
    }
}
