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
    public partial class call_center : Form
    {
        public call_center()
        {
            InitializeComponent();
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

        }

        private void receive_call_click(object sender, EventArgs e)
        {

        }

        private void log_click(object sender, EventArgs e)
        {
            this.Hide();
            callLogs logs = new callLogs();
            logs.Show();
        }
    }
}
