using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    internal class graph
    {

        private int vertices;
        private List<Int32>[] adjLst;
        public graph(int vertices)
        {
            this.vertices = vertices;
            adjLst = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adjLst[i] = new List<int>();
            }

        }
        public void addEdge(int c, int v)
        {
            adjLst[c].Add(v);
        }
        public void DFS(int v)
        {
            bool[] visited = new bool[this.vertices];
            Stack<Int32> stk = new Stack<int>();
            visited[v] = true;
            stk.Push(v);
            while (stk.Count != 0)
            {
                v = stk.Pop();
                foreach (int i in adjLst[v])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        stk.Push(i);

                    }
                }
            }
        }        
    }
}
