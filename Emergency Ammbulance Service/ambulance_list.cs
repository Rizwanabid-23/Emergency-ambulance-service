using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class ambulance_list
    {
        private static ambulance_list instance = null;
        public ambulance_vehicle head { get; set; }
        
        public static ambulance_list vehichleInstance()
        {
            if (instance == null)
            {
                instance = new ambulance_list();
            }
            return instance;
        }

        ambulance_Queue amb_Queue_obj = ambulance_Queue.vehichleQueueInstance();

        private ambulance_list()
        {
            head = null;
        }
        public bool isEmpty() // function will return true if list is empty else return false
        {
            if (this.head == null)
            {
                return true;

            }
            return false;
        }
        public void insert(ambulance_vehicle n) //insert at the start of list
        {
            n.next = head;
            head = n;
            amb_Queue_obj.addAmbulance(n.number);

        }

        public bool deleteVehichle(string x)  //delete all occurrences of x
        {
            ambulance_vehicle h = this.head;
            if (h.number == x)
            {
                head = null;
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

        public ambulance_vehicle searchVehichle(string number)
        {

            ambulance_vehicle veh = this.head;
            while (veh != null)
            {
                if (veh.number == number)
                {
                    return veh;
                }
                veh = veh.next;
            }
            return veh;
        }

        public bool updateStatusToUnAvailable(string num)
        {
            ambulance_vehicle vehichle = searchVehichle(num);
            if (vehichle != null)
            {
                string a = "Not Available";
                vehichle.status = (Status)Enum.Parse(typeof(Status) , a);
            }
            return false;
        }

        public bool updateStatusToAvailable(string num)
        {
            ambulance_vehicle vehichle = searchVehichle(num);
            if (vehichle != null)
            {
                string a = "Available";
                vehichle.status = (Status)Enum.Parse(typeof(Status), a);
            }
            return false;
        }



    }
}

