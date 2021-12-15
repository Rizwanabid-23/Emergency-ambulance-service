using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public class Call
    {
        private string caller;
        private string number;
        private string time;
        private string Duration;
        private string location;
        private string Emergencycode;
        private string patient;
        private string verified;
        private string action;
        private string CTWO;

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