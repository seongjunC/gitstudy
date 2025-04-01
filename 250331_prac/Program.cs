using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250331_prac
{
    internal class Program
    {
        public static void Connect(ref bool[,] array, int a, int b)
        {
            array[a, b] = true;
        }
        static void Main(string[] args)
        {
            bool[,] isConnected = new bool[8, 8];

            Connect(ref isConnected, 0, 4);
            Connect(ref isConnected, 2, 5);
            Connect(ref isConnected, 2, 6);
            Connect(ref isConnected, 3, 7);
            Connect(ref isConnected, 4, 2);
            Connect(ref isConnected, 4, 6);
            Connect(ref isConnected, 5, 1);
            Connect(ref isConnected, 5, 6);
            Connect(ref isConnected, 6, 5);
            Connect(ref isConnected, 6, 4);

            Console.WriteLine("  | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 |");
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{i}");
                for (int j = 0; j < 8; j++)
                {
                    if (isConnected[i, j]) Console.Write($" | 1");
                    else Console.Write(" |  ");
                    if(j == 7)
                    {
                        Console.Write(" |");
                    }
                }
                Console.WriteLine("\n-----------------------------------");
            }
        }
    }
    public class GraphNode<T>
    {
        private T vertex;
        public T Vertex { get { return vertex; } set { vertex = value; } }
        private List<GraphNode<T>> edges = new List<GraphNode<T>>();



        public GraphNode(T vertex)
        {
            this.vertex = vertex;
        }

        public void ConnectVertex(GraphNode<T> node)
        {
            edges.Add(node);
        }

        public void DisConnectVertex(GraphNode<T> node)
        {
            edges.Remove(node);
        }

        public bool IsConnect(GraphNode<T> node)
        {
            return edges.Contains(node);
        }

    }
}