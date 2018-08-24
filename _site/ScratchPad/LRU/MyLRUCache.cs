using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.LRU
{
    // Use a dictionary to store mapping
    // Use a doubly linked list to store access history.
    public class MyLRUCache : ILRUCache
    {
        public class Node
        {
             public int data { get; set; }
             public Node next { get; set; }
             public Node prev { get; set; }

            public Node(int data)
            {
                this.data = data;
            }
        }

        private Dictionary<int, int> _map;

        private readonly int _max;
        private Node head;
        private Node tail;

        public MyLRUCache(int capacity = 16)
        {
            _max = capacity;
            _map = new Dictionary<int, int>(capacity);
            head = null;
            tail = null;
        }

        // Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1
        public int Get(int key)
        {
            throw new NotImplementedException();
            // AddNodeToHead()
        }

        // Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate 
        // the least recently used item before inserting a new item.
        public void Put(int key, int value)
        {
            if (_map.Keys.Count == _max)
            {
                // RemoveTailFromTheList
                // RemoveTailKeyFromMap
                _map[key] = value;
                // AddNodeToHead() 
            }
            else
            {
                _map[key] = value;
                // AddNodeToHead() 
            }
            // UpdateAccessHistory(key);
        }

        private void MoveNodeToHead(int key)
        {
            if (head == null)
            {
                head = tail = new Node(key);
            }
            else
            {
                // Find the node with data as key.
                var runner = head;
                while (runner.data != key)
                {
                    runner = runner.next;
                }

                if (runner != null)
                {
                    if (runner == head)
                    {
                        // do nothing.
                    }

                    else if (runner == tail)
                    {
                        runner.prev.next = null;
                        runner.prev = null;
                        runner.next = head;
                        head.prev = runner;
                        head = runner;
                    }
                    else
                    {
                        runner.prev.next = runner.next;
                        runner.next.prev = runner.prev;
                        runner.next = head;
                        head.prev = runner;
                        head = runner;
                    }
                }
                else
                {
                    // Key not found.
                    var temp = new Node(key);
                    head.prev = temp;
                    temp.next = head;
                    head = temp;
                }
            }
        }
    }
}
