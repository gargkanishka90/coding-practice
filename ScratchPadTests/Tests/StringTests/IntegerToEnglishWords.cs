using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPadTests.Tests.StringTests
{
    public class IntegerToEnglishWords
    {
        public string NumberToWords(int input)
        {
            var map = new Dictionary<int, string>()
            {
                [1] = "One",
                [2] = "Two",
                [3] = "Three",
                [4] = "Four",
                [5] = "Five",
                [6] = "Six",
                [7] = "Seven",
                [8] = "Eight",
                [9] = "Nine",
                [10] = "Ten",
                [11] = "Eleven",
                [12] = "Twelve",
                [13] = "Thirteen",
                [14] = "Fourteen",
                [15] = "Fifteen",
                [16] = "Sixteen",
                [17] = "Seventeen",
                [18] = "Eighteen",
                [19] = "Nineteen",
                [20] = "Twenty",
                [30] = "Thirty",
                [40] = "Forty",
                [50] = "Fifty",
                [60] = "Sixty",
                [70] = "Seventy",
                [80] = "Eighty",
                [90] = "Ninety",
                [100] = "Hundred",
                [1000] = "Thousand",
                [10000000] = "Million",
                [1000000000] = "Billion"
            };

            if (input == 0)
                return "Zero";

            if (input < 21)
            {
                return map[input];
            }

            if (input < 100)
            {
                var inputWithoutRemainder = input / 10;
                var remainder = input % 10;
                if (remainder > 0)
                {
                    return map[inputWithoutRemainder * 10] + " " + map[remainder];
                }
                else
                {
                    return map[inputWithoutRemainder * 10];
                }

            }

            if (input < 1000)
            {
                var inputWithoutRemainder = input / 100;
                var onlyRemainder = input % 100;
                if (onlyRemainder > 0)
                {
                    return map[inputWithoutRemainder] + " " + "Hundred " + NumberToWords(onlyRemainder);
                }
                else
                {
                    return map[inputWithoutRemainder] + " " + "Hundred";
                }
            }

            if (input < 1000000)
            {
                var inputWithoutRemainder = input / 1000;
                var onlyRemainder = input % 1000;
                if (onlyRemainder > 0)
                {
                    return NumberToWords(inputWithoutRemainder) + " " + "Thousand " + NumberToWords(onlyRemainder);
                }
                else
                {
                    return NumberToWords(inputWithoutRemainder) + " " + "Thousand";
                }
            }

            if (input < 1000000000)
            {
                var inputWithoutRemainder = input / 1000000;
                var onlyRemainder = input % 1000000;
                if (onlyRemainder > 0)
                {
                    return NumberToWords(inputWithoutRemainder) + " " + "Million " + NumberToWords(onlyRemainder);
                }
                else
                {
                    return NumberToWords(inputWithoutRemainder) + " " + "Million";
                }
            }

            else
            {
                var inputWithoutRemainder = input / 1000000000;
                var onlyRemainder = input % 1000000000;
                if (onlyRemainder > 0)
                {
                    return NumberToWords(inputWithoutRemainder) + " " + "Billion " + NumberToWords(onlyRemainder);
                }
                else
                {
                    return NumberToWords(inputWithoutRemainder) + " " + "Billion";
                }
            }

            return String.Empty;
        }
    }
}
