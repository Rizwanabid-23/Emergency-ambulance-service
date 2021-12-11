using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public class Person
    {
        public string name { get; private set; }
        public int phone { get; private set; }
        public int CNIC { get; private set; }
        public string address { get; private set; }
        public Person(string name, int phone, int CNIC, string address)
        {
            this.name = name;
            this.phone = phone;
            this.CNIC = CNIC;
            this.address = address;
        }
    }
}
