using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public class CTWO
    {
        public CTWO(string id, string name, string phone, string cnic, string adress, string shift, string employed_as, string password)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Cnic = cnic;
            Adress = adress;
            Shift = shift;
            Employed_as = employed_as;
            Password = password;
        }

        public string Id { get; }
        public string Name { get; }
        public string Phone { get; }
        public string Cnic { get; }
        public string Adress { get; }
        public string Shift { get; }
        public string Employed_as { get; }
        public string Password { get; }
    }
}
