using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ScratchPad.Leetcode.Hard;

namespace ScratchPad.Tests.Leetcode.Hard
{
    [TestFixture]
    public class WordSearchIITests
    {
        [Test, Category("WordSearch")]
        public void Test01_For_NbyN_Grid()
        {
            // Arrange
            var instance = new WordSearchII();
            var grid = new char[,]
            {
                {'o', 'a', 'a', 'n'},
                {'e', 't', 'a', 'e'},
                {'i', 'h', 'k', 'r'},
                {'i', 'f', 'l', 'v'}
            };
            var dictionary = new List<string> { "oath", "pea", "eat", "rain" };

            // Act
            var wordsFound = instance.FindDictionaryWordsInTheGrid(dictionary, grid);

            // Assert
            Assert.AreEqual(2, wordsFound.ToList().Count);
        }

        [Test, Category("WordSearch")]
        public void Test01_For_NbyM_Grid()
        {
            // Arrange
            var instance = new WordSearchII();
            var grid = new char[,]
            {
                {'a', 'a' }
            };
            var dictionary = new List<string> { "aaa"};

            // Act
            var wordsFound = instance.FindDictionaryWordsInTheGrid(dictionary, grid);

            // Assert
            Assert.AreEqual(0, wordsFound.ToList().Count);
        }

        [Test, Category("WordSearch")]
        public void Test01_For_allSameChars_Grid()
        {
            // Arrange
            var instance = new WordSearchII();
            var grid = new char[,]
            {
                {'a', 'a', 'a', 'a'},
                {'a', 'a', 'a', 'a'},
                {'a', 'a', 'a', 'a'},
                {'a', 'a', 'a', 'a'}
            };
            var dictionary = new List<string> { "aaaaaaaaaaaa", "aaaaaaaaaaaa", "aaaaaaaaaaab" };

            // Act
            var wordsFound = instance.FindDictionaryWordsInTheGrid(dictionary, grid);

            // Assert
            Assert.AreEqual(1, wordsFound.ToList().Count);
        }

        [Test]
        public void Test02(){
            var dictionary = new List<string> { "oath", "pea", "eat", "rain" };
            var trie = new WordSearchII.Trie();
            foreach(var word in dictionary){
                trie.InsertWord(word);
            }
            Assert.IsTrue(trie.SearchWord("oath"));
            Assert.IsTrue(trie.SearchWord("eat"));
            Assert.IsTrue(trie.SearchWord("pea"));
            Assert.IsTrue(trie.SearchWord("rain"));
            Assert.IsFalse(trie.SearchWord("oat"));
            Assert.IsTrue(trie.StartsWith("oat"));
        }
    }
}
