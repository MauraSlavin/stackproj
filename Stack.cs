using System;
using System.Collections.Generic;

namespace Stackproj
{
    public class Stack
    {
        public List<object> theStack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
            {
                Console.WriteLine("InvalidOperationException:  Null can't be pushed.");
                // throw new System.ArgumentException("Null can't be pushed.");
            }
            else
            {
                theStack.Add(obj);
            }
        }

        public object Pop()
        {
            var stackLength = theStack.Count;
            // Console.WriteLine(stackLength + " items in the stack (before popping).");
            object poppedItem;
            if (stackLength > 0)
            {
                poppedItem = theStack[stackLength-1];
                // Console.WriteLine("Popped item: " + poppedItem);
                theStack.RemoveAt(stackLength-1);
                // this.DisplayStack();
            }
            else
            {
                Console.WriteLine("InvalidOperationException:  Stack is empty, can't be popped.");
                poppedItem = "** Error **";
                // throw new System.ArgumentException("Empty stack can't be popped.");
            }
            return poppedItem;  
        }

        public void Clear()
        {
            theStack.Clear();
            Console.WriteLine("Stack cleared.");
        }

        public void DisplayStack()
        {
            Console.WriteLine("The stack:  (" + theStack.Count + " items)");
            foreach (object item in theStack)
            {
                Console.WriteLine(item);                
            }
            Console.WriteLine("----------------");
        }
    }
}