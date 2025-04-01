using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250328_prac
{
    internal class Program
    {
        public class MyStack<T>
        {

            public T[] stack = new T[10];
            int index = 0;

            public void push(T element)
            {
                stack[index++] = element;
                if (index == stack.Length -1 )
                {
                    Array.Resize(ref stack, 2 * stack.Length);
                }
            }
            public T Pop()
            {
                T value = stack[--index];
                stack[index] = default;
                return value;
            }

            public T Peek()
            {
                T value = stack[index-1];
                return value;
            }
            public void Clear()
            {
                stack = new T[stack.Length];
            }
            public void ViewAll()
            {
                foreach (T element in stack)
                {
                    Console.Write("{0} ",element);
                }
            }
        }
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.push(1);
            stack.push(2);
            stack.push(1);
            stack.push(2);
            stack.push(1);
            stack.push(2);
            stack.push(1);
            stack.push(2);
            stack.push(1);
            stack.push(2);
            stack.push(1);
            stack.push(2);
            stack.ViewAll();

            Console.WriteLine();

            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            Console.Write(stack.Peek());

            Console.WriteLine();
            stack.ViewAll();

            stack.Clear();
            Console.WriteLine();
            stack.ViewAll();

        }
    }
}
