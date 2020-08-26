using System;

// LIFO stack

namespace Stackproj
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            // Should result in an error.  Stack not changed.
            Console.WriteLine(" ");
            Console.WriteLine("Test pushing 'null'.");
            stack.Push(null);

            Console.WriteLine(" ");
            Console.WriteLine("Test pushing 1, 2, 3; then 3 pops.");
            // Push 1, 2, 3; Pop 3, 2, 1 printing each
            // Show stack after the 3 pushes, and again after the 3 pops.
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.DisplayStack();

            // should output 3, 2, 1
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.DisplayStack();

            Console.WriteLine(" ");
            Console.WriteLine("Test pushing a couple things, then clearing.");
            // two more pushes, to test clearing the stack
            stack.Push(5);
            stack.Push(3);
            stack.DisplayStack();

            stack.Clear();
            stack.DisplayStack();

            Console.WriteLine(" ");
            Console.WriteLine("Test popping an empty stack.");
            // test popping an empty stack
            Console.WriteLine(stack.Pop());

            // make sure pushing 1, 2, 3 and then popping still works.
            Console.WriteLine(" ");
            Console.WriteLine("Test pushing 1, 2, 3; then 3 pops.");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.DisplayStack();

            // should output 3, 2, 1
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.DisplayStack();
        }
    }
}
