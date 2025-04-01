using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Stack<MyClass> st = new Stack<MyClass>();

            for (int i = 0; i < 5; i++)
            {

                st.Push(new MyClass(i));
            }

            st.Pop().Value = 5;

            Console.WriteLine(st.Pop().Value);
        }
    }

    public class MyClass
    {
        public int Value;

        public MyClass(int value)
        {
            Value = value;
        }
    }
}
