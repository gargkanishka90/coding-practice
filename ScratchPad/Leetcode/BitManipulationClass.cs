using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
    public class BitManipulationClass
    {
        public static int HammingWeight(uint n)
        {
            var setBits = 0;
            uint mask = 1;

            while (mask != 0)
            {
                if ((mask & n) != 0)
                {
                    setBits++;
                }
                mask = mask << 1;
            }

            return setBits;
        }

        public static int HammingDistance(int x, int y)
        {
            var dist = 0;

            var mask = 1;

            while (mask != 0)
            {
                var a = x & mask;
                var b = y & mask;

                if (((a^b) & mask) != 0)
                {
                    dist++;
                }
                mask = mask << 1;
            }

            return dist;
        }

        public static uint reverseBits(uint n)
        {
            uint[] arr = new uint[4];

            //uint zero = 0x0000;
            //uint res = 0xf000;

            uint mask = 0x000f;

            var i = 1;

            while (mask > 0 && i <= 4)
            {
                uint temp = n & mask;
                arr[i-1] = temp;
                //res = res & temp;
                mask = mask << (8 * i);
                i++;
                //res = res >> 8 * i;
            }
            

            return 0;
        }
    }
}
