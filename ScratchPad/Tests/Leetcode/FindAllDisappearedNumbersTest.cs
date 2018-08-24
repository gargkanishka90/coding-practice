using System;
using System.Linq;
using NUnit.Framework;
using ScratchPadTests.Leetcode;

namespace ScratchPad.Leetcode
{
    public class FindAllDisappearedNumbersTest
    {
        [Test]
        public static void Find()
        {
            var result = FindAllDisappearedNumbers.FindDisappearedNumbers(new int[] {4, 3, 2, 7, 8, 2, 3, 1});
        } 
    }
}