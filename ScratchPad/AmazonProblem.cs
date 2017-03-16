using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    public class AmazonProblem
    {
        public static List<int> FindVendorWithMostDuplicates(List<Tuple<int, char>> data)
        {
            var VendorToItemMap = new Dictionary<int, List<char>>();
            var ItemToVendorMap = new Dictionary<char, int>();
            foreach(var x in data)
            {
                // add data to VendorToItemMap
                if (!VendorToItemMap.Keys.Contains(x.Item1))
                {
                    VendorToItemMap[x.Item1] = new List<char> { x.Item2 };
                } else
                {
                    VendorToItemMap[x.Item1].Add(x.Item2);
                }

                // add data to ItemToVendorMap
                if (!ItemToVendorMap.Keys.Contains(x.Item2))
                {
                    ItemToVendorMap[x.Item2] = 0;
                }
                else
                {
                    ItemToVendorMap[x.Item2] = 1;
                }
            }

            // process the data in map to get results

            var countMap = new Dictionary<int, int>();

            foreach(var kv in VendorToItemMap)
            {
                countMap[kv.Key] = SumItems(kv.Value, ItemToVendorMap);
            }

            int maxVal = countMap.Values.Max();

            List<int> result = new List<int>();

            foreach(var kv in countMap)
            {
                if(kv.Value == maxVal)
                {
                    result.Add(kv.Key);
                }
            }
            return result;
        }

        private static int SumItems(List<char> value, Dictionary<char, int> data)
        {
            int sum = 0;
            foreach(var i in value)
            {
                sum += data[i];
            }
            return sum;
        }
    }
}
