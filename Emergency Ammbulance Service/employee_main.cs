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
    public partial class employee_main : Form
    {
        public employee_main()
        {
            InitializeComponent();
        }

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }
    }
}
