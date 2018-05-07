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
        private static readonly string GRAPH_FD = "GraphData.txt";
        public static void RunBreadthFirstSearch()
        {
            int startVertex = 1;
            int targetVertex = 6;

            Graph g = new Graph();
            g.ReadInGraph(GRAPH_FD);

            IterativeBFS(startVertex, targetVertex, g);




        }





        private static void IterativeBFS(int startVertex, int targetVertex, Graph g)
        {

            Queue<Vertex> queue = new Queue<Vertex>();
            HashSet<int> visited = new HashSet<int>();
            int[] previousVisited = new int[g.Size() + 1];

            bool found = false;


            previousVisited[startVertex] = 0;
            queue.Enqueue(g.GetVertex(startVertex));
            visited.Add(startVertex);


            while (queue.Count != 0 && !found)
            {
                Vertex current = queue.Dequeue();
                foreach (Edge e in current.neighbours)
                {
                    Vertex v = e.v;

                    if (!visited.Contains(v.value))
                    {
                        visited.Add(v.value);
                        queue.Enqueue(v);
                        previousVisited[e.v.value] = e.u.value;

                    }
                    if (v.value == targetVertex)
                    {
                        found = true;
                        break;
                    }
                }
            }

            //printing shortest path
            int i = targetVertex;
            while (previousVisited[i] != 0)
            {
                int prevNode = previousVisited[i];
                Console.WriteLine(prevNode);
                i = prevNode;
            }


        }



        //make generic at some point <T>
        public static void PrintQueue(Queue<Vertex> q)
        {

            foreach (Vertex v in q)
            {
                Console.WriteLine(v.value);
            }
        }


    }





}
