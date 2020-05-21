using System;

namespace StackOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOfString stack = new StackOfString();
            stack.Push("aff");
            stack.Push("aff");
            stack.Push("aff");
            stack.Push("aff");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.IsEmpty());
        }
    }
}
