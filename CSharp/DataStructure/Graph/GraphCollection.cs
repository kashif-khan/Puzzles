using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.DataStructure.Graph
{
    public class GraphCollection<TData, TWeight>
    {
        public bool IsDirected { get; private set; }

        public bool IsWeighted { get; private set; }

        public GraphCollection(bool isDirected, bool isWeighted = false)
        {
            this.IsDirected = isDirected;
            this.IsWeighted = isWeighted;
        }

        public List<Node<TData, TWeight>> Nodes { get; } = new List<Node<TData, TWeight>>();

        public bool HasNodes { get { return Nodes.Count > 0; } }

        public Edge<TData, TWeight> this[int from, int to]
        {
            get
            {
                var fromNode = Nodes[from];
                var toNode = Nodes[to];
                return this[fromNode, toNode];
            }
        }

        public Edge<TData, TWeight> this[Node<TData, TWeight> from, Node<TData, TWeight> to]
        {
            get
            {
                if (from == null)
                {
                    throw new ArgumentNullException(nameof(from));
                }

                if (to == null)
                {
                    throw new ArgumentNullException(nameof(to));
                }

                var index = from.Neighbors.IndexOf(to);

                if (index > -1)
                {
                    return new Edge<TData, TWeight>(from, to, GetWeight(from, index));
                }

                return null;
            }
        }

        private static TWeight GetWeight(Node<TData, TWeight> from, int index)
        {
            return index < from.Weights.Count ? from.Weights[index] : default(TWeight);
        }

        public Node<TData, TWeight> AddNode(TData value)
        {
            var node = new Node<TData, TWeight>(value);
            Nodes.Add(node);
            UpdateIndices();
            return node;
        }

        public void RemoveNode(Node<TData, TWeight> nodeToRemove)
        {
            Nodes.Remove(nodeToRemove);
            UpdateIndices();
            foreach (var node in Nodes)
            {
                RemoveEdge(node, nodeToRemove);
            }
        }

        public void AddEdge(TData fromNodeData, TData toNodeData, TWeight weight = default)
        {
            var fromNode = Nodes.Where((d, w) => d.Data.Equals(fromNodeData)).FirstOrDefault();

            if (fromNode == null)
            {
                throw new Exception($"{fromNodeData} was not found in the graph");
            }

            var toNode = Nodes.Where((d, w) => d.Data.Equals(toNodeData)).FirstOrDefault();

            if (toNode == null)
            {
                throw new Exception($"{toNodeData} was not found in the graph");
            }

            AddEdge(fromNode, toNode, weight);

            return;
        }

        public void AddEdge(Node<TData, TWeight> fromNode, Node<TData, TWeight> toNode, TWeight weight = default)
        {
            if (fromNode == null)
            {
                throw new ArgumentNullException(nameof(fromNode));
            }

            fromNode.Neighbors.Add(toNode);
            if (IsWeighted)
            {
                fromNode.Weights.Add(weight);
            }

            if (!IsDirected)
            {
                if (toNode == null)
                {
                    throw new ArgumentNullException(nameof(toNode));
                }

                toNode.Neighbors.Add(fromNode);
                if (IsWeighted)
                {
                    toNode.Weights.Add(weight);
                }
            }
        }

        public void RemoveEdge(Node<TData, TWeight> fromNode, Node<TData, TWeight> toNode)
        {
            if (fromNode == null)
            {
                throw new ArgumentNullException(nameof(fromNode));
            }

            int index = fromNode.Neighbors.FindIndex(x => x == toNode);

            if (index >= 0)
            {
                fromNode.Neighbors.RemoveAt(index);

                if (IsWeighted)
                {
                    fromNode.Weights.RemoveAt(index);
                }
            }
        }

        public List<Edge<TData, TWeight>> GetEdges()
        {
            var edges = new List<Edge<TData, TWeight>>();

            foreach (var eachNode in Nodes)
            {
                for (int index = 0; index < eachNode.Neighbors.Count; index++)
                {
                    edges.Add(new Edge<TData, TWeight>(eachNode, eachNode.Neighbors[index], GetWeight(eachNode, index)));
                }
            }

            return edges;
        }

        private void UpdateIndices()
        {
            int i = 0;
            Nodes.ForEach(T => { T.Index = i++; });
        }
    }
}
