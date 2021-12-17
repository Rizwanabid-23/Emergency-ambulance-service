using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class ambulance_Queue
    {
        public ambulance_vehicle head;
        public ambulance_vehicle tail;
        public int QueueSize;

        private ambulance_Queue()
        {
            this.head = null;
            this.tail = null;
            this.QueueSize = 0;
        }



        private static ambulance_Queue instance = null;

        public static ambulance_Queue vehichleQueueInstance()
        {
            if (instance == null)
            {
                instance = new ambulance_Queue();
            }
            return instance;
        }

        ambulance_list amb_List_Obj = ambulance_list.vehichleInstance();

        public void addAmbulance(string entry)    //Function to insert entry in Queue
        {
            ambulance_vehicle veh = new ambulance_vehicle(entry);
            if (this.head == null)
            {
                this.head = veh;
                this.tail = veh;
                this.QueueSize = this.QueueSize + 1;
            }
            else
            {
                this.tail.next = veh;
                this.tail = veh;
                this.QueueSize = this.QueueSize + 1;
            }
            amb_List_Obj.updateStatusToAvailable(veh.number);
        }

        public ambulance_vehicle dispatchAmbulance()   //Function to delete entry in deQueue
        {

            this.QueueSize = this.QueueSize - 1;
            ambulance_vehicle deleteData;
            deleteData = this.head;
            this.head = this.head.next;
            amb_List_Obj.updateStatusToUnAvailable(deleteData.number);
            return deleteData;
        }

        public int sizeOfQueue()  //This function will return size of Queue
        {
            return this.QueueSize;
        }

        public string queueHead()   //This Function will return head of Queue
        {
            return this.head.number;
        }
        public string queueTail()   //This Function will return head of Queue
        {
            return this.tail.number;
        }
    }
}
