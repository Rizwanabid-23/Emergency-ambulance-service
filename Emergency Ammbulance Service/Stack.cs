using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    internal class Stack
    {
        private static Stack instance=null;
        private Stack()
        {
        }
        public static Stack Instance {
            get {
                if (instance == null)
                {
                    instance = new Stack();
                }
                return instance;
            }
        }
        public Node head = null;
        public int stackSize=0;

       

        public void push(int entry, Call call)    //Function to insert entry in stack
        {
            Node nNode = new Node(entry, call);
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

        public Call pop()   //Function to delete entry in destack
        {
            if (this.head == null)
            {
                return null;
            }

            else
            {
                this.stackSize = this.stackSize - 1;
                Call deleteData;
                deleteData = this.head.Call;
                this.head = this.head.next;
                return deleteData;
            }

        }

        public int sizeOfStack()  //This function will return size of stack
        {
            return this.stackSize;
        }

        public Call stackHead()   //This Function will return head of stack
        {
            return this.head.Call;
        }
    }
}
