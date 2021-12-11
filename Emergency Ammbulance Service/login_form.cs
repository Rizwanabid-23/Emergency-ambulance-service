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
        CRI cRI = CRI.Instance;
        public loginForm()
        {
            InitializeComponent();
           

        }


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
            else if(check == "employee")
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
            
            return cRI.varify_EMP(username, pin);
                
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

        private void loginForm_Load(object sender, EventArgs e)
        {
            cRI.load_employee();
        }
    }
}
