using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePad.Leetcode
{
    public class PlusOneClass
    {
        public int[] PlusOne(int[] digits)
        {
            var carry = 1;
            for (var index = digits.Length - 1; index >= 0; index--)
            {
                var temp = carry + digits[index];
                if (temp > 9)
                {
                    digits[index] = temp % 10;
                    carry = temp / 10;
                }
                else {
                    carry = 0;
                    digits[index] = temp;
                }
            }
            var digitList = new List<int>();
            if (carry > 0)
            {
                digitList.Add(carry);
                digitList.AddRange(digits);
                return digitList.ToArray();
            }
            else {
                return digits;
            }
        }
    }
}
