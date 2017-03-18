using System;

namespace ScratchPad.Hashing
{
    public class SingleNumber
    {
        public static int Find(int[] numbers)
        {
            if (numbers.Length <= 2)
            {
                throw new Exception();
            }

            var result = numbers[0];
            for(var i = 1; i < numbers.Length; i++)
            {
                result ^= numbers[i];
            }
            return result;
        } 
    }
}