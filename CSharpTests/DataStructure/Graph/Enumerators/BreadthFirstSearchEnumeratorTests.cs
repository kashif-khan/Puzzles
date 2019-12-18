using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.DataStructure.Graph.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure.Graph.Enumerators.Tests
{
    [TestClass()]
    public class BreadthFirstSearchEnumeratorTests
    {
        [TestMethod()]
        public void BreadthFirstSearchEnumeratorTestCase1()
        {
            var expectedOutputSequence = "1, 2, 3, 4, 5, 6, 7, 8, ";
            var graph = new GraphCollection<int, int>(false);

            for (int i = 1; i < 9; i++)
            {
                graph.AddNode(i);
            }

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 5);
            graph.AddEdge(5, 6);
            graph.AddEdge(5, 7);
            graph.AddEdge(5, 8);

            var iterator = new BreadthFirstSearchEnumerator<int, int>(graph);

            var actualOutputSequence = new StringBuilder();
            while (iterator.MoveNext())
            {
                actualOutputSequence.Append($"{iterator.Current.Data}, ");
            }

            Assert.AreEqual(expectedOutputSequence, actualOutputSequence.ToString(), "DFS output sequence not as expected.");
        }

        [TestMethod()]
        public void BreadthFirstSearchEnumeratorTestCase2()
        {
            var expectedOutputSequence = "1, 2, 3, 4, 8, 5, 6, 7, ";
            var graph = new GraphCollection<int, int>(true, true);

            for (int i = 1; i < 9; i++)
            {
                graph.AddNode(i);
            }

            graph.AddEdge(1, 2, 9);
            graph.AddEdge(1, 3, 5);
            graph.AddEdge(2, 1, 3);
            graph.AddEdge(2, 4, 18);
            graph.AddEdge(3, 4, 12);
            graph.AddEdge(4, 2, 2);
            graph.AddEdge(4, 8, 8);
            graph.AddEdge(5, 4, 9);
            graph.AddEdge(5, 6, 2);
            graph.AddEdge(5, 7, 5);
            graph.AddEdge(5, 8, 3);
            graph.AddEdge(6, 7, 1);
            graph.AddEdge(7, 5, 4);
            graph.AddEdge(7, 8, 6);
            graph.AddEdge(8, 5, 3);

            var iterator = new BreadthFirstSearchEnumerator<int, int>(graph);

            var actualOutputSequence = new StringBuilder();
            while (iterator.MoveNext())
            {
                actualOutputSequence.Append($"{iterator.Current.Data}, ");
            }

            Assert.AreEqual(expectedOutputSequence, actualOutputSequence.ToString(), "DFS output sequence not as expected.");
        }
    }
}