using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.LinkedList
{
    public class CopyListRandomNode
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            var randomMap = new Dictionary<RandomListNode, RandomListNode>();
            var copyMap = new Dictionary<RandomListNode, RandomListNode>();

            var copyRunner = new RandomListNode(-1);
            var copyHead = copyRunner;
            var runner = head;

            while (runner != null)
            {
                var copy = new RandomListNode(runner.label);
                copyMap[copy] = runner;
                randomMap[runner] = runner.random;
                copyRunner.next = copy;
                copyRunner = copyRunner.next;
                runner = runner.next;
            }

            var copyListHead = copyHead.next;

            runner = copyListHead;

            while (runner != null)
            {
                var current = runner;
                var original = copyMap[current];
                var originalRandom = randomMap[original];
                var copyRandom = copyMap.FirstOrDefault(kv => kv.Value == originalRandom).Key;

                runner.random = copyRandom;
                runner = runner.next;
            }

            return copyListHead;
        }

        public RandomListNode CopyRandomListOptimized(RandomListNode head)
        {
            var runner = head;

            while (runner != null)
            {
                var copy = new RandomListNode(runner.label);
                copy.next = runner.next;
                runner.next = copy;
                runner = copy.next;
            }

            var ptr = head;

            while (ptr != null)
            {
                ptr.next.random = ptr.random?.next;
                ptr = ptr.next.next;
            }

            var ptr_old_list = head; // A->B->C
            var ptr_new_list = head.next; // A'->B'->C'
            var head_old = head.next;
            while (ptr_old_list != null)
            {
                ptr_old_list.next = ptr_old_list.next.next;
                ptr_new_list.next = (ptr_new_list.next != null) ? ptr_new_list.next.next : null;
                ptr_old_list = ptr_old_list.next;
                ptr_new_list = ptr_new_list.next;
            }
            return head_old;
        }
    }

    public class RandomListNode
    {
        public int label;
        public RandomListNode next, random;

        public RandomListNode(int x)
        {
            this.label = x;
        }
    }
}
