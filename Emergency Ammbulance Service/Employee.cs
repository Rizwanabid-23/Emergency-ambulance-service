using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public class Employee : Person
    {
        public Employee next { get; set; }
        public int id { get; private set; }
        public Status status { get; private set; }
        public Shift shift { get; private set; }
        public string pin { get; private set; }
        public Type type { get; private set; }

        public Employee(int id, string name, int phone, int cnic, string address, Shift shift, Status status, Type typ, string pin) : base(name, phone, cnic, address)
        {
           
            this.id = id;
            this.status = status;
            this.shift = shift;
            this.pin = pin;
            this.type = typ;
            this.next = null;
        }
    }
}
