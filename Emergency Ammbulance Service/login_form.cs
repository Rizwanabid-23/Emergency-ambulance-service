using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Emergency_Ammbulance_Service
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        //private void removeText()
        //{
        //    if(login_user_box.Text=="Enter usename")
        //    {
        //        login_user_box.Text = "";
        //    }
        //}

        private void login_clicked(object sender, EventArgs e)
        {
            string username = login_user_box.Text;
            string password = login_password.Text;
            string check = verify_user(username, password);
            if(check=="admin")
            {
                this.Hide();
                admin_main admin = new admin_main();
                admin.Show();
            }
            else if(check=="employee")
            {
                this.Hide();
                employee_main employ = new employee_main();
                employ.Show();
            }
            else
            {
                this.Hide();
                failed f = new failed();
                f.Show();
            }

        }
        private bool verify_employee(string username,string pin)
        {
            string[] lines = File.ReadAllLines("C:\\Users\\rizwa\\Documents\\GitHub\\DSA-G34\\dsa2021g34\\Emergency Ammbulance Service\\employee_data.txt");
            foreach (string line in lines)
            {
                string name = get_ID(line, 1);
                string password = get_ID(line, 8);

                if (username == name && pin == password)
                {
                    return true;
                }
            }
            return false;
        }
        private string get_ID(string statement, int position)
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

        private string verify_user(string username, string password)
        {
            if(username=="admin" && password=="123")
            {
                return "admin";
            }
            else if(verify_employee(username,password))
            {
                return "employee";
            }
            else
            {
                return " ";
            }
        }
    }
}
