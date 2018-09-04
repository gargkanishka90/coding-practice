using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ScratchPad.Backtracking;

namespace ScratchPad.Tests.BacktrackingTests
{
    [TestFixture]
    public class BacktrackingTests
    {
        [Test]
        public void Test01()
        {
            var instance = new Permutations();
            //var res = instance.FindAllPermutations("abc");
            //var res1 = instance.Permute(new[] {1, 2, 3});

           // var ss = instance.GetPermutation(3, 5);

            
        }

        [Test]
        public void Palindrome_Partition_Returns_All_Valid_Sets()
        {
            var instance = new PalindromePartition();

            var nitin = instance.Partition("nitin");
            Assert.AreEqual(3, nitin.Count);

            var aab = instance.Partition("aab");
        }
    }
}
