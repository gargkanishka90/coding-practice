using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ScratchPad.Hashing;
using ScratchPadTests.Hashing;

namespace ScratchPad
{
    public class GroupAnagramsTest
    {
        [Test]
        public void GroupAnagTest()
        {
            var words = new string[] { "debitcard", "elvis", "silent",
                                "badcredit", "lives", "freedom",
                                "listen", "levis", "money"};
            var rest = GroupAnagrams.Group(words);
            foreach (var res in rest)
            {
                Console.WriteLine(string.Join(",", res.ToArray()));
            }
        } 
    }
}