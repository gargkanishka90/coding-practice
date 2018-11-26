using NUnit.Framework;
using ScratchPad.Heap;

namespace ScratchPadTests.Tests.Heap
{
    [TestFixture]
    public class MyHeapTests
    {
        [Test]
        public void MyHeap2_MinHeap_Test()
        {
            var instance = new MyHeap2.MinHeap(5);
            var data = new[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (var d in data)
            {
                instance.InsertKey(d);
            }
            Assert.AreEqual(6, instance.PeekMin());
            instance.ExtractMin();
            Assert.AreEqual(7, instance.PeekMin());
        }

        [Test]
        public void MyHeap2_MaxHeap_Test()
        {
            var instance = new MyHeap2.MaxHeap(5);
            var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var d in data)
            {
                instance.InsertKey(d);
            }
            Assert.AreEqual(5, instance.PeekMax());
            instance.ExtractMax();
            Assert.AreEqual(4, instance.PeekMax());
        }

        [Test]
        public void MeetingRoomII_Test()
        {
            // [[0, 30],[5, 10],[15, 20]]
            var instance = new MeetingRoomsII();
            var data = new[] { new MeetingRoomsII.Interval(0,30), new MeetingRoomsII.Interval(5, 10) , new MeetingRoomsII.Interval(15, 20) };
            Assert.AreEqual(2, instance.MinMeetingRooms(data));

            data = new[] { new MeetingRoomsII.Interval(7, 10), new MeetingRoomsII.Interval(2, 4) };
            Assert.AreEqual(1, instance.MinMeetingRooms(data));
        }
    }
}
