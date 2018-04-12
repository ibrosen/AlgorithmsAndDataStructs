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
            List<int> visited = new List<int>();
            Vertex startVertex = g.GetVertex(start);
            Explore(g, startVertex, visited);


            /* If we were to do it iteratively, not recursively, use a stack */
            Stack<Vertex> stack = new Stack<Vertex>();
            stack.Push(startVertex);

        }

        public static void Explore(Graph g, Vertex v, List<int> visited)
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