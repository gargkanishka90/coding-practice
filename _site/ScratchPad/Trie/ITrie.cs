using System.Collections;
using System.Collections.Generic;

namespace ScratchPad
{
    public interface ITrie
    {
        void AddWord(string word, int pos);

        void RemoveWord(string word);

        ICollection<string> GetWords();

        ICollection<string> GetWords(string prefix);

        bool HasWord(string word);

        int WordCount(string word);

        IEnumerable<int> WordPositions(string word);

        void Clear();
    }
}