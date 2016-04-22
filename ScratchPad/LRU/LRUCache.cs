using System;
using System.Collections.Generic;

namespace ScratchPad
{
    public class LeastRecentlyUsedCache<TKey, TValue>
    {
        private readonly Dictionary<TKey, Node> entries;
        private readonly int capacity;
        private Node head;
        private Node tail;

        private class Node
        {
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }

        public LeastRecentlyUsedCache(int capacity = 16)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException(
                    "capacity",
                    "Capacity should be greater than zero");
            this.capacity = capacity;
            entries = new Dictionary<TKey, Node>();
            head = null;
        }

        public void Set(TKey key, TValue value)
        {
            Node entry;
            // if the key is not present.
            if (!entries.TryGetValue(key, out entry))
            {
                entry = new Node { Key = key, Value = value };
                // check number of entries in the cache.
                if (entries.Count == capacity)
                {
                    // update the doubly-linked list which acts as a queue
                    entries.Remove(tail.Key);
                    tail = tail.Previous;
                    if (tail != null) tail.Next = null;
                }
                entries.Add(key, entry);
            }

            entry.Value = value;
            // Make it the most-recently used item by changing the doubly-linked list
            MoveToHead(entry);
            if (tail == null) tail = head;
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            value = default(TValue);
            Node entry;
            if (!entries.TryGetValue(key, out entry)) return false;
            MoveToHead(entry);
            value = entry.Value;
            return true;
        }

        private void MoveToHead(Node entry)
        {
            if (entry == head || entry == null) return;

            var next = entry.Next;
            var previous = entry.Previous;

            if (next != null) next.Previous = entry.Previous;
            if (previous != null) previous.Next = entry.Next;

            entry.Previous = null;
            entry.Next = head;

            if (head != null) head.Previous = entry;
            head = entry;

            if (tail == entry) tail = previous;
        }
    }
}