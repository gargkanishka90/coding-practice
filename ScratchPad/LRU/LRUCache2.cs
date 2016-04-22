// <summary>

using System;
using System.Collections.Generic;
using System.Linq;

namespace ScratchPad
{
    /// Least Recently Used (LRU) cache
    /// </summary>
    public class LRUCache<T>
    {
        internal class CacheItem
        {
            public T Value;
            public int Count;

            public override string ToString()
            {
                return string.Format("Value:{0} Count:{1}", Value, Count);
            }
        }

        Dictionary<int, CacheItem> _data;
        int _capacity;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LRUCache(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException("capacity", "capacity must be a positive number");

            _capacity = capacity;
            _data = new Dictionary<int, CacheItem>(capacity);
        }

        /// <summary>
        /// Get/set value by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns>default(T) if value is not found</returns>
        public T this[int key]
        {
            get
            {
                CacheItem result;

                // Return default(T) if item it not found
                if (!_data.TryGetValue(key, out result))
                    return default(T);

                // Increase usage count if item is found
                result.Count += 1;
                return result.Value;
            }

            set
            {
                CacheItem result;

                // If key already exists then reset usage count and set new value
                if (_data.TryGetValue(key, out result))
                {
                    // If setting the same value assume nothing happend and keep usage
                    if (value.Equals(result.Value))
                        return;

                    result.Value = value;
                    result.Count = 0;
                    return;
                }

                // New key. Check capacity and drop least used key
                if (_capacity <= _data.Count)
                {
                    var sortedUsage = _data.ToList();

                    sortedUsage.Sort((v1, v2) => v1.Value.Count.CompareTo(v2.Value.Count));

                    // Drop least used key
                    _data.Remove(sortedUsage[0].Key);
                }

                _data[key] = new CacheItem() { Value = value };
            }
        }
    }
}