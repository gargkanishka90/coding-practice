using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchPadTests.Hashing
{
    public class CountDistinctElementsInWindow
    {
        public static void Count(int[] arr, int k)
        {
            if(k > arr.Length) throw new Exception();

            var set = new HashSet<int>();
            var dist_count = 0;

            for (var i = 0; i <= arr.Length - k; ++i)
            {
                for (var j = 0; j < k; ++j)
                {
                    if (set.Add(arr[i + j]))
                    {
                        dist_count++;
                    }
                }
                Console.Write(dist_count);
                Console.WriteLine();
                if (set.Remove(arr[i]))
                {
                    dist_count--;
                }
            }
        }

        public static string CountLetters(string input)
        {
            var sb = new StringBuilder();
            var res = new List<string>();
            var map = new Dictionary<char, int>();

            foreach (var character in input.ToLower())
            {
                if (map.ContainsKey(character))
                {
                    map[character]++;
                }
                else
                {
                    map[character] = 1;
                }
            }

            foreach (var key in map.Keys)
            {
                //sb.Append($"{key}:{map[key]},");   
                res.Add($"'{key}':{map[key]}");             
            }

            return string.Join(",", res.ToArray());
        }

        public static string CheckDigit(string input)
        {
            var numbers = new int[17];

            for (var i = 0; i < 17; i++)
            {
                numbers[i] = Convert.ToInt32(input[i]);
            }

            var sumOfDigits = 0;
            for (var index = 0; index < 17; index++)
            {
                if (index % 2 == 0)
                {
                    sumOfDigits += numbers[index] * 3;
                }
                else
                {
                    sumOfDigits += numbers[index];
                }
            }

            var lastDigit = sumOfDigits % 10;
            if (lastDigit > 5)
            {
                return (10 - lastDigit).ToString();
            }
            return lastDigit.ToString();
        }

        public static string CheckCode(string input, string previousInput)
        {
            var newInput = previousInput + input; // Length = 18

            var temp = new int[9];
            var tempList = new List<int>();

            for (var index = 0; index < 17; index += 2)
            {
               // var tempIndex = index;
                //var firstEntry = Convert.ToInt32(newInput[index++]);
                //var secondEntry = Convert.ToInt32(newInput[index]);
                //temp[tempIndex] = firstEntry * 10 + secondEntry;

                var number = Convert.ToInt32(newInput[index].ToString() + newInput[index + 1].ToString());
                //temp[tempIndex] = number;
                tempList.Add(number);
            }

            var arr =  tempList.ToArray();
            var sum = 0;
            for (var index = 0; index <= 8; index++)
            {
                sum += arr[index] * (3 + index);
            }
            sum += 207;
            sum %= 103;

            if (sum >= 10)
            {
                return sum.ToString();
            }
            else
            {
                return "0" + sum.ToString();
            }
        }

        public static bool CheckBalance(string expression)
        {
            var inputPrefixes = expression.ToCharArray();

            var stack1 = new Stack<char>();

            foreach (var prefix in inputPrefixes)
            {
                if (prefix == '<' || prefix == '{')
                {
                    stack1.Push(prefix);
                }
                else
                {
                    if (stack1.Count != 0)
                    {
                        var topOfStack = stack1.Pop();
                        if (!IsOpposite(topOfStack, prefix))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool IsOpposite(char char1, char char2)
        {
            if (char1 == '<' && char2 == '>')
            {
                return true;
            }

            if (char1 == '{' && char2 == '}')
            {
                return true;
            }

            return false;
        }
    }
}