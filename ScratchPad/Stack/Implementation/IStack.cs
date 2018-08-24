using System;
namespace ScratchPad.Stack.Implementation
{
    public interface IStack<T>
    {
        void Push(T itemToAdd);
        T Pop();
        T Peek();
        bool IsEmpty();
        int Size();
    }
}
