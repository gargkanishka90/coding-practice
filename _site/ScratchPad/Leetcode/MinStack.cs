using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.Leetcode
{
//Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

//push(x) -- Push element x onto stack.
//pop() -- Removes the element on top of the stack.
//top() -- Get the top element.
//getMin() -- Retrieve the minimum element in the stack.
    public class MinStack
    {
        public class StackNode
        {
            public int Data { get; set; }
            public int MinSoFar { get; set; }
        }

        private readonly Stack<StackNode> _st;
        
        public MinStack()
        {
            _st = new Stack<StackNode>();
        }

        public void Push(int x)
        {
            var newNode = new StackNode()
            {
                Data = x,
                MinSoFar = x
            };

            if (_st.Count == 0)
            {
                _st.Push(newNode);
            }
            else
            {
                if (newNode.MinSoFar > _st.Peek().MinSoFar)
                {
                    newNode.MinSoFar = _st.Peek().MinSoFar;
                }
                _st.Push(newNode);
            }
        }

        public void Pop()
        {
            if (_st.Count == 0)
            {
                throw new Exception("Stack is Empty.");
            }
            _st.Pop();
        }

        public int Top()
        {
            if(_st.Count > 0)
                return _st.Peek().Data;
            else 
                throw new Exception("Stack is Empty.");
        }

        public int GetMin()
        {
            if (_st.Count > 0)
                return _st.Peek().MinSoFar;
            else
                throw new Exception("Stack is Empty.");
        }
    }
}
