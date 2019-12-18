using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure.Graph
{
    public class Edge<T, W>
    {
        public Node<T, W> From { get; private set; }

        public Node<T, W> To { get; private set; }

        public W Weight { get; private set; }

        public Edge(Node<T, W> from, Node<T, W> to, W weight)
        {
            this.From = from;
            this.To = to;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return $"Edge: {From.Data} -> {To.Data}, Weight: {Weight}";
        }
    }
}
