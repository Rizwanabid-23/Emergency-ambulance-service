using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class ambulance_vehicle
    {
        public ambulance_vehicle next;
        public string number;
        public Status status;
        public string dispachTime;
        public string arrivalTime;
        public ambulance_vehicle(string num)
        {
            this.number = num;
            this.next = null;
        }
        public ambulance_vehicle(string num, Status stat)
        {
            this.number = num;
            this.status = stat;
            this.next = null;
        }
        public ambulance_vehicle(string plate_numb, Status stat, string dispachtime, string arrivaltime)
        {
            this.number = plate_numb;
            this.status = stat;
            this.dispachTime = dispachtime;
            this.arrivalTime = arrivaltime;
            this.next = null;
        }
    }
}
