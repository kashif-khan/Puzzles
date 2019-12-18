using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure.Graph.Enumerators
{
    public sealed class BreadthFirstSearchEnumerator<TData, TWeight> : IEnumerator<Node<TData, TWeight>>
    {

        private bool[] IsVisited;

        public Node<TData, TWeight> Current { get; private set; } = null;

        object IEnumerator.Current => Current;

        public GraphCollection<TData, TWeight> Graph { get; }

        public bool LeftToRight { get; set; }

        Queue<Node<TData, TWeight>> nodeQueue = new Queue<Node<TData, TWeight>>();

        public BreadthFirstSearchEnumerator(GraphCollection<TData, TWeight> graph, bool leftToRight = true)
        {
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
            while (nodeQueue.Any())
            {
                Current = nodeQueue.Dequeue();
                IsVisited[Current.Index] = true;

                if (this.LeftToRight)
                {
                    foreach (var neighbor in Current.Neighbors)
                    {
                        if (!IsVisited[neighbor.Index])
                        {
                            nodeQueue.Enqueue(neighbor);
                            IsVisited[neighbor.Index] = true;
                        }
                    }
                }
                else
                {
                    for (int i = Current.Neighbors.Count - 1; i >= 0; i--)
                    {
                        var neighbor = Current.Neighbors[i];
                        if (!IsVisited[neighbor.Index])
                        {
                            nodeQueue.Enqueue(neighbor);
                            IsVisited[neighbor.Index] = true;
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public void Reset()
        {
            IsVisited = new bool[this.Graph.Nodes.Count];
            nodeQueue.Clear();
            if (this.Graph.HasNodes)
            {
                nodeQueue.Enqueue(this.Graph.Nodes.First());
            }
        }
    }
}
