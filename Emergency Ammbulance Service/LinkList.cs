using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class LinkList
    {
        public Employee head { get; private set; }

        // public varibles and methods of link list are here
        public LinkList() // Constructor of link list
        {
            head = null;
        } // constructor

        public bool isEmpty() // function will return true if list is empty else return false
        {
            if (this.head == null)
            {
                return true;

            }
            return false;
        }
        public void insert(Employee n) //insert at the start of list
        {
            n.next = head;
            head = n;

        }

        public bool delete(string x, int id)  //delete all occurrences of x
        {
            Employee h = this.head;
            if (h.name == x && h.id == id)
            {
                head = null;
                head = head.next;
                return true;
            }
            while (h.next != null)
            {
                if (h.next.name == x && h.id == id)
                {
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
            Employee h = this.head;
            while (h != null)
            {
                counter = counter + 1;
                h = h.next;
            }
            return counter;
        }
        

    }
}
