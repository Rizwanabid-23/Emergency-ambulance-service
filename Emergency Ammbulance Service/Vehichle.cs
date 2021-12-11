using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class Vehichle
    {
        public Vehichle next;
        public string number;
        public string status;
        public string dispachTime;
        public string arrivalTime;
        public Vehichle(string num, string stat)
        {
            this.number = num;
            this.status = stat;
            this.next = null;
        }
        public Vehichle(string num, string stat, string dispachtime, string arrivaltime)
        {
            this.number = num;
            this.status = stat;
            this.dispachTime = dispachtime;
            this.arrivalTime = arrivaltime;
            this.next = null;
        }
    }
}
