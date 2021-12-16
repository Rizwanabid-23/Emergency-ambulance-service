using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Ammbulance_Service
{
    public class Employee : Person
    {
        public Employee next { get; set; }
        public int id { get; private set; }
        public int rating { get; private set; }
        public Status status { get; private set; }
        public Shift shift { get; private set; }
        public string pin { get; private set; }
        public Type type { get; private set; }
        public Employee(int id, string name, int rating, int phone, int cnic, string address, Shift shift, Status status, Type typ) : base(name, phone, cnic, address)
        {

            this.id = id;
            this.rating = rating;
            this.status = status;
            this.shift = shift;
            this.type = typ;
            this.next = null;
        }

        public Employee(int id, string name, int rating, int phone, int cnic, string address, Shift shift, Status status, Type typ, string pin) : base(name, phone, cnic, address)
        {
           
            this.id = id;
            this.rating = rating;
            this.status = status;
            this.shift = shift;
            this.pin = pin;
            this.type = typ;
            this.next = null;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setRating(int rating)
        {
            this.rating=rating;
        }
        public void setShift(Shift shift)
        {
            this.shift = shift;
        }
        public void setCNIC(int cnic)
        {
            this.CNIC = cnic;
        }
        public void setPhone(int phone)
        {
            this.phone = phone;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public void setStatus(Status status)
        {
            this.status=status;
        }
        public void setPin(string pin)
        {
            this.pin = pin;
        }
        public void setType(Type type)
        {
            this.type=type;
        }
        public void UpdateEmployee(int id, string name, int rating, int phone, int cnic, string address, Shift shift, Status status, Type typ)
        {
            base.name = name;
            base.CNIC = cnic;
            base.phone = phone;
            base.address = address;
            this.id = id;
            this.rating = rating;
            this.status = status;
            this.shift = shift;
            this.type = typ;
            
        }

        public void UpdateEmployee(int id, string name, int rating, int phone, int cnic, string address, Shift shift, Status status, Type typ, string pin) 
        {
            base.name = name;
            base.CNIC = cnic;
            base.phone = phone;
            base.address = address;
            this.id = id;
            this.rating = rating;
            this.status = status;
            this.shift = shift;
            this.pin = pin;
            this.type = typ;
            
        }


    }
}
