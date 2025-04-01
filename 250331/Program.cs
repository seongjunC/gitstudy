using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250331
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }



    public class GraphNode<T>
    {
        private T vertex;
        public T Vertex { get { return vertex; } set { vertex = value;  } }

        private List<GraphNode<T>> edges =new List<GraphNode<T>>();

        public GraphNode(T vertex){
            this.vertex = vertex;    
        }

        public void AddEdge(GraphNode<T> node)
        {
            edges.Add(node);
        }
        public void RemoveEdge(GraphNode<T> node)
        {
            
                edges.Remove(node);
        }
        public bool IsConnect(GraphNode<T> node)
        {
            return edges.Contains(node);
        }

    }
}
