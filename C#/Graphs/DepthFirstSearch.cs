using System;
using System.Collections.Generic;
using csharp.Graphs;

namespace csharp
{
    class DepthFirstSearch
    {

        public static void RunDepthFirstSearch(int start)
        {
            Graph g = new Graph();
            g.ReadInGraph("GraphData.txt");
            HashSet<int> visited = new HashSet<int>();
            Vertex startVertex = g.GetVertex(start);

            Console.WriteLine("Recursive");
            Explore(g, startVertex, visited);


            /* If we were to do it iteratively, not recursively, use a stack */
            Console.WriteLine("Iterative");
            Stack<Vertex> stack = new Stack<Vertex>();
            visited = new HashSet<int>();
            stack.Push(startVertex);

            while (stack.Count != 0)
            {
                var current = stack.Pop();
                Console.WriteLine(current.value);

                visited.Add(current.value);
                foreach (Edge e in current.neighbours)
                {
                    var currentNeighbour = e.v;
                    if (!visited.Contains(currentNeighbour.value) && !stack.Contains(currentNeighbour))
                    {
                        stack.Push(currentNeighbour);
                    }

                }
            }
        }

        public static void Explore(Graph g, Vertex v, HashSet<int> visited)
        {
            visited.Add(v.value);
            Console.WriteLine(v.value);
            foreach (Edge edge in v.neighbours)
            {
                Vertex neighbour = edge.v;
                if (!visited.Contains(neighbour.value))
                {
                    Explore(g, neighbour, visited);
                }
            }
        }
    }
}