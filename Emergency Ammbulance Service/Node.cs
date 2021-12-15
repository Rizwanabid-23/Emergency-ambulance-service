using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public class Node
    {
        public int data;
        public Node next;
        public Call Call { get; set; }
        public Node parent;
        public Node(int data)
        {
            this.data = data;  
        }
        public Node(int data, Call call)
        {
            this.data = data;
            this.next = null;
        }
    }
}
