using System;

namespace dsa2021g34
{
    class Node
    {
        public int data;
        public Node next;
    
        public Node(int data) 
        {
            this.data = data;
            this.next = null;
        }
    }

    class Stack
    {
        public Node head;
        public int stackSize;

        public Stack() {
            this.head = null;
            this.stackSize = 0;
        }

        public void push(int entry)    //Function to insert entry in stack
        {
            Node nNode = new Node(entry);
            if (this.head == null) {
                this.head = nNode;
                this.head.next = null;
                this.stackSize = this.stackSize+1;
            }

            else {
                nNode.next = head;
                this.head = nNode;
                this.stackSize = this.stackSize+1;
            }
        }

        public int pop()   //Function to delete entry in destack
        {
            if (this.head == null){ 
                return 0;
            }

            else {
                this.stackSize = this.stackSize-1;
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


 
class Queue
    {
        public Node head;
        public Node tail;
        public int QueueSize;

        public Queue() {
            this.head = null;
            this.tail = null;
            this.QueueSize = 0;
        }

        public void push(int entry)    //Function to insert entry in Queue
        {
            Node nNode = new Node(entry);
            if (this.head == null) {
                this.head = nNode;
                this.tail = nNode;
                this.QueueSize = this.QueueSize+1;
            }

            else {
                this.tail.next = nNode;
                this.tail = nNode;
                this.QueueSize = this.QueueSize+1;
            }
        }

        public int pop()   //Function to delete entry in deQueue
        {
            if (this.head == null){ 
                return 0;
            }

            else {
                this.QueueSize = this.QueueSize-1;
                int deleteData = 0;
                deleteData = this.head.data;
                this.head = this.head.next;
                return deleteData;
            }

        }
    
        public int sizeOfQueue()  //This function will return size of Queue
        {
            return this.QueueSize;
        }
        
        public int queueHead()   //This Function will return head of Queue
        {
            return this.head.data;
        }
        public int queueTail()   //This Function will return head of Queue
        {
            return this.tail.data;
        }
    

    class Program
    {
        static void Main(string[] args)
        {
   
        }
    }
}
