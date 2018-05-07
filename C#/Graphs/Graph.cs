using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace csharp.Graphs
{
    public class Graph
    {
        public List<Vertex> vertices;
        public void AddNeighbour(int u, int v)
        {
            Vertex vertexU = GetVertex(u);
            Vertex vertexV = GetVertex(v);
            Edge edge = new Edge(vertexU, vertexV);
            vertexU.neighbours.Add(edge);
        }

        public Vertex GetVertex(int value)
        {
            return vertices.Where(vertex => vertex.value == value).First();
        }

        public int Size()
        {
            return vertices.Count;
        }

        public Graph()
        {
            vertices = new List<Vertex>();
        }

        public void ReadInGraph(string filename)
        {
            StreamReader f = new StreamReader(File.Open("Graphs/" + filename, FileMode.Open));
            int numVertices = Convert.ToInt16(f.ReadLine());
            //read in initial vertices
            for (int i = 0; i < numVertices; i++)
            {
                int vertexNum = Convert.ToInt32(f.ReadLine());
                vertices.Add(new Vertex(vertexNum));
            }
            //add all the edges
            while (!f.EndOfStream)
            {
                var line = f.ReadLine();
                var lineCommaSplit = line.Split(',');
                int u = Convert.ToInt32(lineCommaSplit[0]);
                int v = Convert.ToInt32(lineCommaSplit[1]);
                AddNeighbour(u, v);
            }

        }

        public void ReadOutGraph()
        {
            foreach (Vertex v in vertices)
            {
                foreach (Edge e in v.neighbours)
                {
                    Console.WriteLine(e.u.value + " " + e.v.value);
                }
            }
        }


    }

    public class Vertex
    {
        public int value { get; set; }
        public List<Edge> neighbours;

        public Vertex()
        {
            neighbours = new List<Edge>();
        }
        public Vertex(int val)
        {
            value = val;
            neighbours = new List<Edge>();
        }
    }

    public class Edge
    {
        public int weight { get; set; }
        public Vertex u { get; set; }
        public Vertex v { get; set; }
        public Edge() { }
        public Edge(Vertex u, Vertex v)
        {
            this.u = u;
            this.v = v;
        }
    }
}