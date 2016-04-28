using System;

namespace ScratchPad
{
    public class LinkedListUtillities
    {
        public static LinkNode GenerateSinglyLinkedListFromArray(int[] arr)
        {
            var root = new LinkNode(arr[0], null, null);
            var current = root;

            for (var i = 1; i < arr.Length; i++)
            {
                var newNode = new LinkNode(arr[i], null, null);
                current.SetNext(newNode);
                //newNode.SetPrevious(current);
                current = current.Next;
            }
            //current.SetNext(new LinkNode(-999, null, null));
            return root;
        }

        public static LinkNode GenerateSinglyLinkedListFromArrayWithCycle(int[] arr, int k = 5)
        {
            var root = new LinkNode(arr[0], null, null);
            var current = root;
            var cycleLen = arr.Length - k;
            

            

            for (var i = 1; i < arr.Length; i++)
            {
                var newNode = new LinkNode(arr[i], null, null);
                current.SetNext(newNode);
                //newNode.SetPrevious(current);
                current = current.Next;
            }
            
            //current.SetNext(new LinkNode(-999, null, null));
            var temp = root;
            while (cycleLen > 0)
            {
                temp = temp.Next;
                cycleLen--;

            }
            current.Next = temp;
            return root;
        }

        public static void PrintSLL(LinkNode node)
        {
            while (node != null)
            {
                //Console.WriteLine();
                //Console.WriteLine("Prev : " + node.Prev.Data);
                Console.WriteLine(node.Data);
                //Console.WriteLine("Next : " + node.Next.Data);
                node = node.Next;
            }
            //Console.WriteLine("Prev : " + node.Prev.Data);
            //Console.WriteLine(node.Data);
            //Console.WriteLine("Next : " + node.Next.Data);
            //Console.WriteLine();
        }
    }
}