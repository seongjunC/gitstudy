using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weightgraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphNode<int>[] arrayGraph = new GraphNode<int>[8];
            
            for (int i = 0; i < arrayGraph.Length; i++) {
                arrayGraph[i] = new GraphNode<int>(i);
            }

            arrayGraph[0].ConnectNode(arrayGraph[3], 4);
            arrayGraph[0].ConnectNode(arrayGraph[5], 2);
            arrayGraph[0].ConnectNode(arrayGraph[2], 55);
            arrayGraph[4].ConnectNode(arrayGraph[1], 4);
            arrayGraph[6].ConnectNode(arrayGraph[0], 21);
            arrayGraph[2].ConnectNode(arrayGraph[7], 33);
            arrayGraph[5].ConnectNode(arrayGraph[2], 7);
            arrayGraph[4].ConnectNode(arrayGraph[3], 9);
            arrayGraph[7].ConnectNode(arrayGraph[1], 3);
            foreach (GraphNode<int> node in arrayGraph)
            {
                node.PrintEdges();
            }


        }


    }
    public class GraphNode<T>
    {
        private T node;
        public T Node { get { return node; } }
        public Dictionary<GraphNode<T>, int> weight = new Dictionary<GraphNode<T>,int>();
        public List<GraphNode<T>> edges = new List<GraphNode<T>>();


        public GraphNode(T node)
        {
            this.node = node;
        }

 
            public void ConnectNode(GraphNode<T> vertex, int weight)
        {
            if (!edges.Contains(vertex))
            {
                edges.Add(vertex);
                this.weight.Add(vertex, weight);
                vertex.ConnectNode(this, weight);
            }
            else
            {
                this.weight.TryGetValue(vertex, out int now);
                if (now > weight)
                {
                    this.weight[vertex] = weight;
                }
            }
        }
        public void DisConnectNode(GraphNode<T> vertex)
        {
            if (edges.Contains(vertex))
            {
                edges.Remove(vertex);
                this.weight.Remove(vertex);
                vertex.DisConnectNode(this);
            }
        }

        public void PrintEdges() {
            if (edges.Count > 0)
            {
                Console.Write($"{node}노드 : ");
                foreach (GraphNode<T> edge in edges)
                {
                    Console.Write($" - {edge.node} 노드, 가중치 {this.weight[edge], -3}");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"{node}노드 : 간선이 없습니다.");
            }
        }

        
    }
}
