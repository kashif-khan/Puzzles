using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure.Graph
{
    public class Node<T, W>
    {
        public int Index { get; set; }

        public T Data { get; private set; }

        public Node(T data)
        {
            this.Data = data;
        }

        public List<Node<T, W>> Neighbors { get; } = new List<Node<T, W>>();

        public List<W> Weights { get; } = new List<W>();

        public override int GetHashCode()
        {
            return Index;
        }
        public override string ToString()
        {
            return $"Node with index {Index}: {Data}, neighbors: {Neighbors.Count}";
        }
    }
}
