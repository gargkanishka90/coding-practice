using System;
using System.Collections.Generic;

namespace ScratchPad
{
    public class LRUCache3
    {
        public class Node
        {
            public int data;
            public int key;
            public Node prev;
            public Node next;
        }

        private Dictionary<int, Node> _map;
        public Node head;
        public Node tail;
        private int capacity;
        
        public LRUCache3(int capacity = 16)
        {
            _map = new Dictionary<int, Node>(capacity);
            this.capacity = capacity;
            head = null;
        }

        public void Set(int key, int data)
        {
            // check if it is in the hash table. if yes, move it to head. otherwise, add it to map and move it to head. 
            Node entry;
            if (!_map.TryGetValue(key, out entry))
            {
                // entry is not there in the map
                entry = new Node() {data = data, key = key};

                if (_map.Count == capacity)
                {
                    // map is at full capacity now so most aged entity from the table and the list. 
                    _map.Remove(tail.key);
                    tail = tail.prev;
                    if (tail != null)
                        tail.next = null;
                }
                _map[key] = entry;
            }
            entry.data = data;
            MoveToHead(entry);
            if (tail == null)
                tail = head;
        }

        public bool Get(int key, out int value)
        {
            value = default(int);
            Node entry;
            if (!_map.TryGetValue(key, out entry)) return false;
            value = entry.data;
            MoveToHead(entry);
            return true;
        }

        private void MoveToHead(Node entry)
        {
            if (entry == null || entry == head) return;
            var next = entry.next;
            var prev = entry.prev;

            if (next != null) next.prev = entry.prev;
            if (prev != null) prev.next = entry.next;

            entry.prev = null;
            entry.next = head;
            if (head != null) head.prev = entry;
            head = entry;

            if (tail == entry)
                tail = prev;

        }

        public void Print()
        {
            foreach (var kv in _map.Keys)
            {
                Console.WriteLine("Key: " + kv + " Value: " + _map[kv].data);
            }
        }
    }
}