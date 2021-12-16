using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public class Call
    {
        public string caller { get; private set;}
        public string number { get; private set; }
        public string time { get; private set; }
        public string Duration { get; private set; }
        public string location { get; private set; }
        public string Emergencycode { get; private set; }
        public string patient { get; private set; }
        public string verified { get; private set; }
        public string action { get; private set; }
        public string CTWO { get; private set; }

        public Call(string caller, string number, string time, string duration, string location, string emergencycode, string patient, string verified, string action, string cTWO)
        {
            this.caller = caller;
            this.number = number;
            this.time = time;
            Duration = duration;
            this.location = location;
            Emergencycode = emergencycode;
            this.patient = patient;
            this.verified = verified;
            this.action = action;
            this.CTWO = cTWO;
        }
    }
}