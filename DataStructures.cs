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


    class Person
    {
        public int data;
        public Person next;
    
        public Person(int data) 
        {
            this.data = data;
            this.next = null;
        
        }
    }

    class LinkList {
        private Person head;

     // public varibles and methods of link list are here
        public LinkList() // Constructor of link list
        {
            head = null; 
        } // constructor

        public bool isEmpty() // function will return true if list is empty else return false
        {
            if (this.head == null) {
                return true;

            }
            return false;
        }
        public void insertAtHead(int x) //insert at the start of list
        {
            Person n = new Person(x);
            n.next = head;
            head = n;
            

            
        }


        public bool searchPerson(int x) //search for data value x in the list
        {
            Person h = this.head;
            while (h != null) {
                if (h.data == x) {
                    return true;
                }
                h = h.next;

            }
            return false;
        }
        public bool deletePerson(int x)  //delete all occurrences of x
        {
            Person h = this.head;
            if (h.data == x) {
                head = null;
                head = head.next;
                return true;
            }
            while (h.next != null) {
                if (h.next.data == x) {
                    //h.next = null;
                    h.next = h.next.next;
                    return true;
                }
                h = h.next;
            }
            return false;
        }
        public int size() 
        {
            int counter = 0;
            Person h = this.head;
            while(h != null) {
                counter = counter+1;
                h = h.next;
            }
            return counter;
        }


        public void display() 
        {
            Console.WriteLine("In display");
            Person h = this.head;
            while(h != null) {
                Console.Write(h.data);
                Console.Write("      n     ");
                h = h.next;
            }

        }


    }
    class NodeT {
        public int key;
        public NodeT parent;
        public NodeT left;
        public NodeT right;
        public NodeT(int ky) {
            this.key = ky;
            this.parent = null;
            this.left = null;
            this.right = null;
        } 
    }


    class Tree {

        public NodeT root;
        private NodeT NodeTFind;
        public Tree() {
            this.root = null;
        }


        public void Insert_NodeT(Tree T , int data) // Function to insert new NodeT in Tree
        {
            NodeT z = new NodeT(data);
            NodeT y = null;
            NodeT x = T.root;
            while (x!= null) {
                y = x;
                if (z.key < x.key) {
                    x = x.left;
                }  
                else {
                    x = x.right;
                }
            }    
            z.parent = y;
            if (y == null) {
                T.root = z;
            }    
            else if (z.key < y.key) {
                y.left = z;
            }
            else {
                y.right = z;
            }
        }

        public void transplant(Tree t , NodeT u , NodeT v)
        {
            if (u.parent == null) {
                t.root = v;
            }
            else if (u == u.parent.left) {
                u.parent.left = v;
            }
            else {
                u.parent.right = v;
            }
            if (v != null) {
                v.parent = u.parent;
            }
        }

        public NodeT minimumT(NodeT x) {
            while(x.left != null) {
                x = x.left;
            }
            return x;
        }

        public void deleteNodeT(Tree T , int data)
        {
            bool nod = this.search(data);
            if (nod == true) {
                if (this.NodeTFind.left == null) {
                    this.transplant(T , this.NodeTFind , this.NodeTFind.right);
                }
                else if (this.NodeTFind.right == null) {
                    this.transplant(T , this.NodeTFind , this.NodeTFind.left);
                }
                else {
                    NodeT y = this.minimumT(this.NodeTFind.right);
                    if (y.parent != this.NodeTFind) {
                        this.transplant(T , y , y.right);
                        y.right = this.NodeTFind.right;
                        y.right.parent = y;
                    }
                    this.transplant(T , this.NodeTFind , y);
                    y.left = this.NodeTFind.left;
                    y.left.parent = y;
                }

            }
            else {
                Console.WriteLine("Not in th this Found");
            }
        }


        public void In_order_Traversel(NodeT NodeT) {
            if (NodeT != null) {
                this.In_order_Traversel(NodeT.left);
                Console.Write(NodeT.key);
                this.In_order_Traversel(NodeT.right);
            }

        }

        public bool search(int searchNodeT) {
            NodeT x = this.root;
            while(x != null && searchNodeT != x.key ) {
                if (searchNodeT < x.key ) {
                    x = x.left;
                }
                else {
                    x = x.right;
                }
            }
            if (x == null) {
                return false;
            }
            this.NodeTFind = x;
            return true;

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
}

    class Program
    {
        static void Main(string[] args)
        {
   
        }
    }
}
