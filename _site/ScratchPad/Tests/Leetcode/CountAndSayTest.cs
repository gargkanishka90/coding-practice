using System;
using NUnit.Framework;
using PracticePad.Leetcode;

namespace ScratchPad.Tests.Leetcode
{
    [TestFixture]
    public class CountAndSayTest
    {
        [Test]
        public void CountAndSayTest1()
        {
            var instance = new CountAndSayClass();
            for (var i = 3; i <= 8; i++){
                Console.WriteLine($"{i}-th:" + instance.CountAndSay(i));
            }
        }
    }
}
