using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.Leetcode.Hard;

namespace ScratchPadTests.Tests.Leetcode.Hard
{
    [TestFixture]
    public class AutocompleteSystemTests
    {
        [Test]
        public void Test01()
        {
            var instance = new AutocompleteSystem(new [] {"i love you", "island", "ironman", "i love leetcode"}, new []{5, 3, 2, 2});
            var queryResult = instance.Input('i');
            PrintQueryResult(queryResult);

            queryResult = instance.Input(' ');
            PrintQueryResult(queryResult);

            queryResult = instance.Input('a');
            PrintQueryResult(queryResult);

            queryResult = instance.Input('#');
            PrintQueryResult(queryResult);

            queryResult = instance.Input('i');
            PrintQueryResult(queryResult);

            queryResult = instance.Input(' ');
            PrintQueryResult(queryResult);

            queryResult = instance.Input('a');
            PrintQueryResult(queryResult);

            queryResult = instance.Input('#');
            PrintQueryResult(queryResult);
        }

        public void PrintQueryResult(IList<string> items){
            Console.WriteLine();
            if (items.Count == 0)
                Console.WriteLine("[]");
            Console.Write("[");
            foreach (var item in items){
                Console.Write(item + " , ");
            }
            Console.WriteLine("]");
        }
    }
}
