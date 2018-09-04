using System;
using NUnit.Framework;
using ScratchPad.Stack.Implementation;

namespace ScratchPad.Tests.Stack
{
    [TestFixture]
    public class StackUsingArrayTests
    {
        [Test]
        public void Test01(){
            var stack = new StackUsingArray<string>();
            stack.Push("apple");
            stack.Push("banana");
            stack.Push("carrot");
            Assert.AreEqual(3, stack.Size());
            Assert.AreEqual("carrot", stack.Peek());
            Assert.AreEqual("carrot", stack.Pop());
            Assert.AreEqual(2, stack.Size());
            Assert.AreEqual("banana", stack.Peek());
        }
    }
}
