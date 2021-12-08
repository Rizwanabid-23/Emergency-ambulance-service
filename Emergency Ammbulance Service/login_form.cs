using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emergency_Ammbulance_Service
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_clicked(object sender, EventArgs e)
        {
            string username = login_user_box.Text;
            string password = login_password.Text;
            bool check = verify_user(username, password);
            if(check)
            {
                this.Hide();
                admin_main admin = new admin_main();
                admin.Show();
            }
            else
            {
                this.Hide();
                failed f = new failed();
                f.Show();
            }

        }
        private bool verify_user(string username, string password)
        {
            if(username=="admin" && password=="123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
