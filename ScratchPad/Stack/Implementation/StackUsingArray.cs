using System;
namespace ScratchPad.Stack.Implementation
{
    public class StackUsingArray<T> : IStack<T>
    {
        T[] _items;
        int current = 0;

        public StackUsingArray(int defaultSize=16)
        {
            _items = new T[defaultSize];
            current = 0;
        }

        public bool IsEmpty()
        {
            return current > 0;
        }

        public T Peek()
        {
            if (current <= 0)
                throw new Exception("Underflow");

            return _items[current - 1];
        }

        public T Pop()
        {
            if (current <= 0)
                throw new Exception("Underflow");

            current--;
            return _items[current];
        }

        public void Push(T itemToAdd)
        {
            _items[current] = itemToAdd;
            current++;
        }

        public int Size()
        {
            return current;
        }
    }
}
