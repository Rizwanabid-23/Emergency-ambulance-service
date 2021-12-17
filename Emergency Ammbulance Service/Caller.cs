using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class Caller
    {
        public Caller parent;
        public Caller left;
        public Caller right;

        public string name;
        public string location;
        public string address;
        public string cnic;
        public string number;
        public long EC;
        public Caller(string name, string number, string location, string cnic, string address)
        {
            this.name = name;
            this.number = number;
            this.location = location;
            this.cnic = cnic;
            this.address = address;
            this.parent = null;
            this.left = null;
            this.right = null;
            //this.EC = this.Hash(name);
        }


    }
}
