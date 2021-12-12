using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class VehichleList
    {
        public Vehichle head { get; private set;  }
        private VehichleList()
        {
            head = null;
        }

        public Vehichle getVHead()
        {
            return this.head;
        }

        private static VehichleList vList;
        public static VehichleList vehichleInstance()
        {
            if (vList == null)
            {
                vList = new VehichleList();
            }
            return vList;
        }


        public bool isEmpty() // function will return true if list is empty else return false
        {
            if (this.head == null)
            {
                return true;

            }
            return false;
        }
        public void insert(Vehichle n) //insert at the start of list
        {
            n.next = head;
            head = n;

        }

        public bool deleteVehichle(string x)  //delete all occurrences of x
        {
            Vehichle h = this.head;
            if (h.number == x)
            {
                head = head.next;
                return true;
            }
            while (h.next != null)
            {
                if (h.next.number == x)
                {
                    h.next = h.next.next;
                    return true;
                }
                h = h.next;
            }
            return false;
        }

        public bool verifyVehichle(string num) // Function will return true if user will true otherwise return
        {                                               // else return false
            Vehichle h = this.head;
            while (h != null)
            {
                if (h.number == num)
                {
                    return true;
                }
                h = h.next;
            }
            return false;
        }

        public int size()
        {
            int counter = 0;
            Vehichle h = this.head;
            while (h != null)
            {
                counter = counter + 1;
                h = h.next;
            }
            return counter;
        }


    }
}

