using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    internal class Stack
    {
        public Node head;
        public int stackSize;

        public Stack()
        {
            this.head = null;
            this.stackSize = 0;
        }

        public void push(int entry)    //Function to insert entry in stack
        {
            Node nNode = new Node(entry);
            if (this.head == null)
            {
                this.head = nNode;
                this.head.next = null;
                this.stackSize = this.stackSize + 1;
            }

            else
            {
                nNode.next = head;
                this.head = nNode;
                this.stackSize = this.stackSize + 1;
            }
        }

        public int pop()   //Function to delete entry in destack
        {
            if (this.head == null)
            {
                return 0;
            }

            else
            {
                this.stackSize = this.stackSize - 1;
                int deleteData = 0;
                deleteData = this.head.data;
                this.head = this.head.next;
                return deleteData;
            }

        }

        public int sizeOfStack()  //This function will return size of stack
        {
            return this.stackSize;
        }

        public int stackHead()   //This Function will return head of stack
        {
            return this.head.data;
        }
    }
}
