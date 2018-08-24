using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.LRU
{
    public interface ILRUCache
    {
        int Get(int key);

        void Put(int key, int value);
    }
}
