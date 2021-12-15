using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class priority_queue
    {
        public Node head;
        public Node tail;

        priority_queue()
        {
            this.head = null;
            this.tail = null;
        }

        public void enqueue(Node node)
        {
            if(this.isEmpty())
            {
                this.head = this.tail = node;
            }
            else
            {
                this.tail.next = node;
                this.tail = this.tail.next;
            }
        }

        public int size()
        {
            int counter = 0;
            while(this.head!=null)
            {
                counter++;
                head = head.next;
            }
            return counter;
        }

        public bool isEmpty()
        {
            if(this.head==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
