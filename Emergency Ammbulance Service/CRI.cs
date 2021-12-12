using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Emergency_Ammbulance_Service
{
    internal class CRI
    {
        private static CRI instance = null;

        private CRI()
        {
        }
        public static CRI Instance {
            get {
                if (instance == null)
                {
                    instance = new CRI();
                }
                return instance;
            }
        }

        public string Username { get; private set; }
        public string password { get; private set; }

        public EmpList eLst = EmpList.emplyInstance();
        public VehichleList Vlst = VehichleList.vehichleInstance();
        public void add_employee(Employee n) 
        {
            eLst.insert(n);
            
        }
        public Employee head() { return eLst.head; }



        
    }
        
}
