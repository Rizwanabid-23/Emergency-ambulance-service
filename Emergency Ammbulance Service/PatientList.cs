using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    class PatientList
    {
        private List<PatientData> ptData = new List<PatientData>();
        private PatientList()
        {
         
        }

        private static PatientList instance = null;

        public static PatientList patInstance()
        {
            if (instance == null)
            {
                instance = new PatientList();
            }
            return instance;
        }

        public void insert(PatientData p )
        {
            ptData.Add(p);
        }

    }
}
