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
    public partial class parking : Form
    {
        public parking()
        {
            InitializeComponent();
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

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm form = new loginForm();
            form.Show();

        }

        private void log_click(object sender, EventArgs e)
        {
            this.Hide();
            callLogs log = new callLogs();
            log.Show();
        }
    }
}
