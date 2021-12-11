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
      
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public int Phone { get; set; }
        public int Cnic { get; set; }
        public string Adress { get; set; }
        public string Shift { get; set; }
        public string Employed_as { get; set; }
        public string Password { get; set; }
    }
}
