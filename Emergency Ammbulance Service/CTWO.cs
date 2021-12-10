using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public class CTWO
    {
        public CTWO(int id, string name, int rating, int phone, int cnic, string adress, string shift, string employed_as, string password)
        {
            Id = id;
            Name = name;
            Rating = rating;
            Phone = phone;
            Cnic = cnic;
            Adress = adress;
            Shift = shift;
            Employed_as = employed_as;
            Password = password;
        }
      
        public int Id { get; }
        public string Name { get; }
        public int Rating { get; }
        public int Phone { get; }
        public int Cnic { get; }
        public string Adress { get; }
        public string Shift { get; }
        public string Employed_as { get; }
        public string Password { get; }
    }
}
