using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace Emergency_Ammbulance_Service

{
    internal class CRI
    {
        private static CRI instance = null;
        private Employee head;
        private ambulance_vehicle Ahead;

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
        //public string Username { get; private set; }
        //public string password { get; private set; }

        public EmpList lst = EmpList.Instance;
        public ambulance_list a_list = ambulance_list.vehichleInstance();

        public void add_ambulance(ambulance_vehicle a)
        {
            a_list.insert(a);
            this.Ahead = a_list.head;
        }
        public ambulance_vehicle get_amb_head()
        {
            return a_list.head;
        }

        public void add_employee(Employee n)
        {
            lst.insert(n);
            this.head = lst.head;
        }
        public Employee gethead()
        {
            return this.head;
        }
        public void load_employee()
        {
            Shift shift;
            Type typ;
            Status status;
            int id;
            string name;
            int rating;
            int CNIC;
            int phone;
            string adress, shft, st, type;
            string password;
            string[] lines = File.ReadAllLines("employee_data.txt");

            foreach (string line in lines)
            {
                id = int.Parse(getStr(line, 0));
                name = getStr(line, 1);
                rating = int.Parse(getStr(line, 2));
                CNIC = int.Parse(getStr(line, 3));
                phone = int.Parse(getStr(line, 4));
                adress = getStr(line, 5);
                shft = getStr(line, 6);
                st = getStr(line, 7);
                type = getStr(line, 8);
                password = getStr(line, 9);
                Enum.TryParse(shft, out shift);
                Enum.TryParse(st, out status);
                Enum.TryParse(type, out typ);
                Employee emp = new Employee(id, name, rating, phone, CNIC, adress, shift, Status.Unavailable, typ, password);
                add_employee(emp);

            }
        }
        private string getStr(string statement, int position)
        {
            int idx = 0;
            int comma = 0;
            string word = "";
            while (idx < statement.Length)
            {
                char c = statement[idx];
                if (c == ',')
                {
                    comma++;
                }
                else if (comma == position)
                {
                    word = word + c;
                }
                idx++;
            }
            return word;
        }
        public bool varify_EMP(string name, string password)
        {
            Employee y = this.head;
            while (y != null)
            {
                if (y.name == name && y.pin == password)
                {
                    return true;
                }
                y = y.next;
            }
            return false;
        }
        public Employee searchEmployee(string attrib, String keyword)
        {

            Employee employee = this.head;
            while (employee != null)
            {
                if ((attrib == "Name") && (keyword == employee.name))
                {
                    return employee;
                }
                else if ((attrib == "Shift") && (keyword == employee.shift.ToString()))
                {
                    return employee;
                }
                else if ((attrib == "Catagory") && (keyword == employee.type.ToString()))
                {
                    return employee;
                }
                else if ((attrib == "Phone") && (keyword == employee.phone.ToString()))
                {
                    return employee;
                }

                employee = employee.next;



            }
            return employee;
        }
        public bool delete(Employee x)  // Here function overloading is used to overload delete person
        {                               // This will delete the employ which we want to search

            return lst.delete(x);
        }
        public ambulance_vehicle getVhead()
        {
            return a_list.head;
        }
        public void load_Ambulance()
        {
            Status status;
            string st;
            string plate;
            string Driver;
            string emt;
            string[] lines = File.ReadAllLines("vehicle_data.txt");

            foreach (string line in lines)
            {
                plate = getStr(line, 0);
                st = getStr(line, 1);
                Driver = getStr(line, 2);
                emt = getStr(line, 3);
                Enum.TryParse(st, out status);
                ambulance_vehicle av = new ambulance_vehicle(plate, status);
                if (Driver != "null" && emt != "null")
                {
                    Employee emp = this.searchEmployee("Driver", Driver);
                    Employee EMT = this.searchEmployee("EMT", emt);
                    av.setDriver(emp);
                    av.setEmT(EMT);
                }
                a_list.insert(av);
            }
        }
    }
}