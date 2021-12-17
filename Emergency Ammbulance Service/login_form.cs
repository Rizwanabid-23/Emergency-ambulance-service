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
            login_password.PasswordChar = '*';
        }


        private void login_clicked(object sender, EventArgs e)
        {
     
            string username = login_user_box.Text;
            string password = login_password.Text;
            Employee employee;
            string check = verify_user(username, password);
            
            
           
            if(check=="admin")
            {
     
                admin_main admin = new admin_main();
                admin.Show();
            }
            else if(check == "employee")
            {

       
                employee_main employ = new employee_main();
                if (login_user_box.Text != null && password != null && check != " ")
                {
                    employee = cRI.searchEmployee("Pass", password , Type.CTWO);
                    employ.setEMp(employee);
                    employ.Show();

                }
                
                
            }
            else
            {
                
                failed f = new failed();
                f.Show();
            }
            login_user_box.Clear();
            login_password.Clear();
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
            cRI.load_Ambulance();
        }

        private void pin_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pin_checkBox.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
            
        }

        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to exit program ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();
            }
        }
    }
}
