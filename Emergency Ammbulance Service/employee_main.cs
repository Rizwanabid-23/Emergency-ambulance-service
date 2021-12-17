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
        Employee loggedin;
        public employee_main()
        {
            InitializeComponent();
        }

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void profile_click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void call_center_click(object sender, EventArgs e)
        {
            this.Hide();
            call_center call_Center = new call_center();
            call_Center.Show();
        }

        private void current_status_click(object sender, EventArgs e)
        {
            this.Hide();
            current_status status = new current_status();
            status.Show();

        }

        private void parking_click(object sender, EventArgs e)
        {
            this.Hide();
            parking park = new parking();
            park.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            callLogs callLogs = new callLogs();
            callLogs.Show();
        }

        public void setEMp(Employee logdin)
        {
            this.loggedin = logdin;   
        }
        private void profile_load(object sender, EventArgs e)
        {
            try
            {
                id_label.Text = loggedin.id.ToString();
                name_label.Text = loggedin.name;
                rating_label.Text = loggedin.rating.ToString();
                postion_label.Text = loggedin.type.ToString();
                shift_label.Text = loggedin.shift.ToString();
                phone_label.Text = loggedin.phone.ToString();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Not Found");
            }
            



        }
    }
}
