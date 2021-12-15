using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Emergency_Ammbulance_Service
{
    class node_graph
    {
        public int numVertices;
        public List<List<Node>> adjList;
        node_graph(int v)
        {
            this.adjList = new List<List<Node>>();
            for (int i = 0; i < v; i++)
            {
                adjList.Add(new List<Node>());
            }
            this.numVertices = v;
        }

        void add_directed_edge(int src,int dest)
        {
            Node node1 = new Node(dest);
            this.adjList[src].Add(node1);
            
        }
        
    }
}
