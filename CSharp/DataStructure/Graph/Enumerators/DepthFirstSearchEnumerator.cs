using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure.Graph.Enumerators
{
    public sealed class DepthFirstSearchEnumerator<TData, TWeight> : IEnumerator<Node<TData, TWeight>>
    {
        private bool[] IsMarkedToBeVisited;

        public Node<TData, TWeight> Current { get; private set; } = null;

        object IEnumerator.Current => Current;

        public GraphCollection<TData, TWeight> Graph { get; }

        public bool LeftToRight { get; set; }

        public Stack<Node<TData, TWeight>> nodeStack { get; private set; } = new Stack<Node<TData, TWeight>>();

        public DepthFirstSearchEnumerator(GraphCollection<TData, TWeight> graph, bool leftToRight = false)
        {
            if (graph == null)
            {
                throw new ArgumentNullException(nameof(graph));
            }

            this.Graph = graph;

            this.LeftToRight = leftToRight;

            Reset();
        }

        public void Dispose()
        {
            // Nothing to dispose
        }

        public bool MoveNext()
        {
            while (nodeStack.Count > 0)
            {
                Current = nodeStack.Pop();
                IsMarkedToBeVisited[Current.Index] = true;

                if (this.LeftToRight)
                {
                    for (int i = Current.Neighbors.Count - 1; i >= 0; i--)
                    {
                        var neighbor = Current.Neighbors[i];

                        if (!IsMarkedToBeVisited[neighbor.Index])
                        {
                            nodeStack.Push(neighbor);
                            IsMarkedToBeVisited[neighbor.Index] = true;
                        }
                    }
                }
                else
                {
                    foreach (var neighbor in Current.Neighbors)
                    {
                        if (!IsMarkedToBeVisited[neighbor.Index])
                        {
                            nodeStack.Push(neighbor);
                            IsMarkedToBeVisited[neighbor.Index] = true;
                        }
                    }
                }

                return true;
            }
            return false;
        }

        public void Reset()
        {
            nodeStack.Clear();
            IsMarkedToBeVisited = new bool[this.Graph.Nodes.Count];
            if (this.Graph.HasNodes)
            {
                nodeStack.Push(this.Graph.Nodes.First());
            }
        }
    }
}
