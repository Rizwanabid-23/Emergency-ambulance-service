using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emergency_Ammbulance_Service
{
    public partial class call_center : Form
    {

     

        public call_center()
        {
            InitializeComponent();
            load_Caller();
        }

        private void parking_click(object sender, EventArgs e)
        {
            this.Hide();
            parking park = new parking();
            park.Show();
        }

        private void profile_click(object sender, EventArgs e)
        {
            this.Hide();
            employee_main profile = new employee_main();
            profile.Show();
        }

        private void call_center_click(object sender, EventArgs e)
        {
            this.Hide();
            call_center center = new call_center();
            center.Show();
        }

        private void current_status_clicked(object sender, EventArgs e)
        {
            current_status status = new current_status();
            this.Hide();
            status.Show();
        }

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm form = new loginForm();
            form.Show();
        }

        private void decline_click(object sender, EventArgs e)
        {

        }

        private void dispatch_click(object sender, EventArgs e)
        {
            this.Hide();
            dispatch_ambulance dispatch = new dispatch_ambulance();
            dispatch.Show();
        }

        private void receive_call_click(object sender, EventArgs e)
        {
            CallerBst cb = CallerBst.bstInstance();
            string pnumber = PhoneNumber.Text;
            Caller obj = cb.search(pnumber);
            textBox4.Text = obj.name;
            textBox3.Text = obj.location;
            textBox2.Text = obj.number;
            textBox5.Text = obj.address;
            textBox6.Text = obj.cnic;
            

            


        }

        private void log_click(object sender, EventArgs e)
        {
            this.Hide();
            callLogs logs = new callLogs();
            logs.Show();
        }
        public void load_Caller()
        {
            
            string name, location, address, cnic, number;
            string[] lines = File.ReadAllLines("Caller.txt");

            foreach (string line in lines)
            {
                name = getStr(line, 0);
                number = getStr(line, 1);
                cnic = getStr(line, 2);
                location = getStr(line, 3);
                address = getStr(line, 4);
                Caller caller = new Caller(name, number,location,cnic, address);
                CallerBst bst = CallerBst.bstInstance();
                bst.Insert_Caller(caller);

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

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
