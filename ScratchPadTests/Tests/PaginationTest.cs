using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ScratchPad.Companies;

namespace ScratchPadTests.Tests
{
    [TestFixture]
    public class PaginationTest
    {
        [Test]
        public void Test01()
        {
            var places = new []{
                "1,28,310.6,SF",
                "4,5,204.1,SF",
                "20,7,203.2,Oakland",
                "6,8,202.2,SF",
                "6,10,199.1,SF",
                "1,16,190.4,SF",
                "6,29,185.2,SF",
                "7,20,180.1,SF",
                "6,21,162.1,SF",
                "2,18,161.2,SF",
                "2,30,149.1,SF",
                "3,76,146.2,SF",
                "2,14,141.1,San Jose"
            };
            var result = Pagination.GetDisplay(places,5);
            Assert.AreEqual(15, result.Count);
            Assert.AreEqual("1,28,310.6,SF", result[0]);
            Assert.AreEqual("7,20,180.1,SF", result[4]);
            Assert.AreEqual(" ", result[5]);
            Assert.AreEqual("6,10,199.1,SF", result[6]);
            Assert.AreEqual("6,29,185.2,SF", result[10]);
            Assert.AreEqual(" ", result[11]);
            Assert.AreEqual("6,21,162.1,SF", result[12]);
            Assert.AreEqual("2,14,141.1,San Jose", result[14]);
        }

        [Test]
        public void Test02()
        {
            var places = new []{
                    "1,28,300.1,SanFrancisco",
                    "4,5,209.1,SanFrancisco",
                    "20,7,208.1,SanFrancisco",
                    "23,8,207.1,SanFrancisco",
                    "16,10,206.1,Oakland",
                    "1,16,205.1,SanFrancisco",
                    "6,29,204.1,SanFrancisco",
                    "7,20,203.1,SanFrancisco",
                    "8,21,202.1,SanFrancisco",
                    "2,18,201.1,SanFrancisco",
                    "2,30,200.1,SanFrancisco",
                    "15,27,109.1,Oakland",
                    "10,13,108.1,Oakland",
                    "11,26,107.1,Oakland",
                    "12,9,106.1,Oakland",
                    "13,1,105.1,Oakland",
                    "22,17,104.1,Oakland",
                    "1,2,103.1,Oakland",
                    "28,24,102.1,Oakland",
                    "18,14,11.1,SanJose",
                    "6,25,10.1,Oakland",
                    "19,15,9.1,SanJose",
                    "3,19,8.1,SanJose",
                    "3,11,7.1,Oakland",
                    "27,12,6.1,Oakland",
                    "1,3,5.1,Oakland",
                    "25,4,4.1,SanJose",
                    "5,6,3.1,SanJose",
                    "29,22,2.1,SanJose",
                    "30,23,1.1,SanJose"
            };
            var result = Pagination.GetDisplay(places, 12);
            Assert.AreEqual(32, result.Count);
            Assert.AreEqual("1,28,300.1,SanFrancisco", result[0]);
            Assert.AreEqual("11,26,107.1,Oakland", result[11]);
            Assert.AreEqual(" ", result[12]);
            Assert.AreEqual("1,16,205.1,SanFrancisco", result[13]);
            Assert.AreEqual("2,30,200.1,SanFrancisco", result[14]);
            Assert.AreEqual("25,4,4.1,SanJose", result[24]);
            Assert.AreEqual(" ", result[25]);
            Assert.AreEqual("1,2,103.1,Oakland", result[26]);
            Assert.AreEqual("3,11,7.1,Oakland", result[27]);
            Assert.AreEqual("30,23,1.1,SanJose", result[30]);
            Assert.AreEqual("1,3,5.1,Oakland", result[31]);
        }
    }
}
