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

            return FindOptimalValue(values, weights, values.Length - 1, capacity, V);
        }

        public int FindOptimalValue(int[] values, int[] weights, int totalItems, int totalCapacity, int[,] memory){
            if (totalItems < 0)
                return 0;

            if(memory[totalItems, totalCapacity] == -1){
                var withoutIncluding = FindOptimalValue(values, weights, totalItems - 1, totalCapacity, memory);

                var withIncluding = totalCapacity < weights[totalItems] ? 0
                    : values[totalItems] + FindOptimalValue(values, weights, totalItems - 1, totalCapacity - weights[totalItems], memory);

                memory[totalItems, totalCapacity] = Math.Max(withIncluding, withoutIncluding);
            }

            return memory[totalItems, totalCapacity];
        }
    }
}
