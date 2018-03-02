using System.Collections;
using System.Collections.Generic;

namespace ScratchPad
{
    public class TrieNode
    {
        public char Character { get; set; }

        public IDictionary<char, TrieNode> Children { get; set; }

        public List<int> Positions { get; set; } 

        public int WordCount { get; set; }

        public bool IsWord
        {
            get { return WordCount > 0; }
        }

        public TrieNode(char character, IDictionary<char, TrieNode> children, int wordCount)
        {
            Character = character;
            Children = children;
            WordCount = wordCount;
            Positions = new List<int>();
        }

        public IEnumerable<TrieNode> GetChildren()
        {
            return Children.Values;
        }

        public TrieNode GetChild(char character)
        {
            TrieNode child;
            Children.TryGetValue(character, out child);
            return child;
        }

        public void SetChild(TrieNode child)
        {
            Children[child.Character] = child;
        }

        public void RemoveChild(char character)
        {
            Children.Remove(character);
        }

        public void Clear()
        {
            Children.Clear();
            WordCount = 0;
        }

        public override string ToString()
        {
            return Character.ToString();
        }

        public override bool Equals(object obj)
        {
            TrieNode that;
            return
                obj != null
                && (that = obj as TrieNode) != null
                && that.Character == this.Character;
        }

        public override int GetHashCode()
        {
            return Character.GetHashCode();
        }
    }
}