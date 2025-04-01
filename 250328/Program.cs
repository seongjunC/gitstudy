using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250328
{
    internal class Program
    {
        static public int Josephus(int n , int k)
        {
            int lastNum = 0;
            LinkedList<int> Josephus = new LinkedList<int>();
            

            for (int i = 0; i < n; i++)
            {
                Josephus.AddLast(i+1);
            }
            LinkedListNode<int> outNode = Josephus.Last;
            for (int i = 1; i < n; i++)
            {

                for (int j = 0; j < k; j++)
                {
                    if (outNode == null || outNode == Josephus.Last)
                    {
                        outNode = Josephus.First;
                    }
                    else { outNode = outNode.Next; }
                }
                LinkedListNode<int> nextNode = outNode.Next;
                Josephus.Remove(outNode);
                if (nextNode == null)
                {
                    outNode = Josephus.Last;
                }
                else
                {
                    outNode = nextNode.Previous;
                }
            }
            lastNum = Josephus.First();
            return lastNum;
        }

        static public bool Parenthesis(string str)
        {
            Stack<int> small = new Stack<int>();
            Stack<int> middle = new Stack<int>();
            Stack<int> big = new Stack<int>();

            List<int> smallpairs =  new List<int> ();
            List<int> middlepairs = new List<int>();
            List<int> pairs = new List<int>();

            foreach (char c in str)
            {
                if(c == '(')
                {
                    small.Push(1);
                }
                if (c == ')')
                {
                    small.Push(-1); 
                }
                if(c == '{')
                {
                    middle.Push(1);
                }
                if(c == '}')
                {
                    middle.Push(-1);
                }
                if(c == '[')
                {
                    big.Push(1);
                }
                if(c == ']')
                {
                    big.Push(-1);
                }
            }

            while(small.Count > 0)
            {
                smallpairs.Add(small.Pop());
            }
            if(smallpairs.Count % 2 == 1)
            {
                return false;
            }
            for (int i = 0; i < smallpairs.Count / 2; i++)
            {
                if (smallpairs[2*i] == 1 || smallpairs[2*i+1] == -1)
                {
                    return false;
                }
            }

            while (middle.Count > 0)
            {
                middlepairs.Add(middle.Pop());
            }
            if (middlepairs.Count % 2 == 1)
            {
                return false;

            }
            foreach (int i in middlepairs)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < middlepairs.Count / 2; i++)
            {
                if (middlepairs[2 * i] == 1 || middlepairs[2 * i + 1] == -1)
                {
                    return false;
                }
            }

            while (big.Count > 0)
            {
                pairs.Add(big.Pop());
            }
            if (pairs.Count % 2 == 1)
            {
                return false;
            }
            for (int i = 0; i < pairs.Count / 2; i++)
            {
                if (pairs[2 * i] == 1 || pairs[2 * i + 1] == -1)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = 41;
            int k = 3;

            Console.WriteLine("요세푸스 문제 : {0}",Josephus(n, k));

            string str = "(){}{}[(])";
            Console.WriteLine("괄호 문제 : {0} ", Parenthesis(str));
        }
    }
}
