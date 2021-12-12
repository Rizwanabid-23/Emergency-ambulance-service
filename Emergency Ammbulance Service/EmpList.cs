using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class EmpList
    {
        private static EmpList instance = null;
        public Employee head { get; private set; }

        
        public static EmpList Instance {
            get {
                if (instance == null)
                {
                    instance = new EmpList();
                }
                return instance;
            }
        }
        

        // public varibles and methods of link list are here
        private EmpList() // Constructor of link list
        {
            head = null;
        } // constructor

        private static EmpList vList;
        public static EmpList emplyInstance()
        {
            if (vList == null)
            {
                vList = new EmpList();
            }
            return vList;
        }

        public Employee getEHead() // FUnction will return head of employ List
        {
            return this.head;
        }


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

        public bool delete(string x, int id)  //delete occurrences of x
        {
            Employee h = this.head;
            if (h.name == x && h.id == id)
            {
                head = head.next;
                return true;
            }
            while (h.next != null)
            {
                if (h.next.name == x && h.next.id == id)
                {
                    h.next = h.next.next;
                    return true;
                }
                h = h.next;
            }
            return false;
        }

        public bool delete(Employee x)  // Here function overloading is used to overload delete person
        {                               // This will delete the employ which we want to search
            Employee h = this.head;
            if (h == x)
            {
                head = head.next;
                return true;
            }
            while (h.next != null)
            {
                if (h.next == x)
                {
                    h.next = h.next.next;
                    return true;
                }
                h = h.next;
            }
            return false;
        }


        public bool verifyEmply(int cnic, string name) // Function will return true if user will true otherwise return
        {                                               // else return false
            Employee h = this.head;
            while (h != null)
            {
                if (h.CNIC == cnic && h.name == name)
                {
                    return true;
                }
                h = h.next;
            }
            return false;
        }

        public bool searchEmp(int searchby , string toSearch) //search for data value toSearch in the list
        {
            Employee h = this.head;
            Employee temp;
            if (searchby == 0) // This condition is for name
            {
                if (searchby == 0)
                {
                    while (h != null)
                    {
                        if (h.name == toSearch)
                        {
                            temp = h;
                            this.delete(h);
                            Employee e = new Employee(temp.id, temp.name, temp.phone, temp.CNIC, temp.address, temp.shift, temp.status, temp.type, temp.pin);
                            this.insert(e);
                        }
                        h = h.next;
                    }
                }
            }
            else if (searchby == 1)  // This condition is for ratings
            {

            }
            else if (searchby == 2)
            {
                // Category
            }
            else if (searchby == 3)
            {
                // shift
            }
            else if (searchby == 4)
            {
                // Phone
            }

            return false;

        }

        public int size() // Function will return size of list
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
