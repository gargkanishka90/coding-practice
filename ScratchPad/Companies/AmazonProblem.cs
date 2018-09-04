using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad
{
    public class AmazonProblem
    {
        public static List<int> FindVendorWithMostDuplicates(List<Tuple<int, char>> data)
        {
            var vendorToItemMap = new Dictionary<int, List<char>>();
            var itemToVendorMap = new Dictionary<char, int>();
            foreach(var x in data)
            {
                // add data to VendorToItemMap
                if (!vendorToItemMap.Keys.Contains(x.Item1))
                {
                    vendorToItemMap[x.Item1] = new List<char> { x.Item2 };
                } else
                {
                    vendorToItemMap[x.Item1].Add(x.Item2);
                }

                // add data to ItemToVendorMap
                if (!itemToVendorMap.Keys.Contains(x.Item2))
                {
                    itemToVendorMap[x.Item2] = 0;
                }
                else
                {
                    itemToVendorMap[x.Item2] = 1;
                }
            }

            // process the data in map to get results

            var countMap = new Dictionary<int, int>();

            foreach(var kv in vendorToItemMap)
            {
                countMap[kv.Key] = SumItems(kv.Value, itemToVendorMap);
            }

            var maxVal = countMap.Values.Max();

            var result = new List<int>();

            foreach(var kv in countMap)
            {
                if(kv.Value == maxVal)
                {
                    result.Add(kv.Key);
                }
            }
            return result;
        }

        private static int SumItems(List<char> value, IReadOnlyDictionary<char, int> data)
        {
            var sum = 0;
            foreach(var i in value)
            {
                sum += data[i];
            }
            return sum;
        }
    }
}
