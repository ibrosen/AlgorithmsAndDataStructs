using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using csharp.Graphs;
using System.Collections;

namespace csharp
{
    public class BreadthFirstSearch
    {
        public static void RunBreadthFirstSearch(int targetVertex)
        {
            Graph g = new Graph();
            g.ReadInGraph("GraphData.txt");
            Queue<Vertex> queue = new Queue<Vertex>();
            List<int> visited = new List<int>();
            queue.Enqueue(g.GetVertex(1));
            visited.Add(1);
            bool found = false;
            int layer = 1;
            while (queue.Count != 0 && !found)
            {
                Vertex current = queue.Dequeue();
                foreach (Edge e in current.neighbours)
                {
                    Vertex v = e.v;
                    if (v.value == targetVertex)
                    {
                        PrintQueue(queue);
                        Console.WriteLine(layer);
                        found = true;
                        break;
                    }
                    if (!visited.Contains(v.value))
                    {
                        visited.Add(v.value);
                        queue.Enqueue(v);

                    }
                }
                layer++;
            }


        }
        //make generic at some point
        public static void PrintQueue(Queue<Vertex> q)
        {

            foreach (Vertex v in q)
            {
                Console.WriteLine(v.value);
            }
        }


    }





}
