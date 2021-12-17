using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class PatientData
    {

        public string name;
        public string hospital;
        public string reportedBy;
        public string cnic;
        public string contact;
  
        public PatientData(string name, string hospital, string reportedBy, string contact , string cnic)
        {
            this.name = name;
            this.hospital = hospital;
            this.reportedBy = reportedBy;
            this.cnic = cnic;
            this.contact = contact;
        }
    }
}
