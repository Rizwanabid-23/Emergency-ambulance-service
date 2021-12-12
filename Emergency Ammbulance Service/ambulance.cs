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
    public partial class ambulance : Form
    {
        public ambulance()
        {
            InitializeComponent();
        }

        private void employee_click(object sender, EventArgs e)
        {
            this.Hide();
            admin_main employee_options = new admin_main();
            employee_options.Show();
        }

        private void ambulance_click(object sender, EventArgs e)
        {
            this.Hide();
            ambulance ambulance = new ambulance();
            ambulance.Show();
        }

        private void log_out_click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void add_ambulance_click(object sender, EventArgs e)
        {
            add_ambulance ambulance = new add_ambulance();
            ambulance.Show();
        }

        private void ctwo_report_clicked(object sender, EventArgs e)
        {
            this.Hide();
            analytic_report report = new analytic_report();
            report.Show();
        }

        private void shift_clcik(object sender, EventArgs e)
        {
            this.Hide();
            shifts shifts = new shifts();
            shifts.Show();
        }

        private void call_log_clciked(object sender, EventArgs e)
        {
            this.Hide();
            callLogs log = new callLogs();
            log.Show();
        }
    }
}
