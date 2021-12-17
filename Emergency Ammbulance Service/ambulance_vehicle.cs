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
        public string number { get; private set; }
        public Status status { get; private set; }
        public string dispachTime { get; private set; }
        public string arrivalTime { get; private set; }
        public Employee driver { get; private set; }
        public Employee EMT { get; private set; }

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
            driver = null;
        }
        public ambulance_vehicle(string plate_numb, Status stat, string dispachtime, string arrivaltime)
        {
            this.number = plate_numb;
            this.status = stat;
            this.dispachTime = dispachtime;
            this.arrivalTime = arrivaltime;
            this.next = null;
        }
        public void setDriver(Employee employee)
        {
            this.driver = employee;   
        }
        public void setEmT(Employee emp)
        {
            this.EMT = emp;
        }
        public void setDispatchTime(string time)
        {
            this.dispachTime = time;
        }
        public void setStatus(Status st)
        {
            this.status = st;
        }
    }
}
