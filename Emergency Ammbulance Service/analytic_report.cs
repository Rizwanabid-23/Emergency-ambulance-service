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
    public partial class analytic_report : Form
    {
        public analytic_report()
        {
            InitializeComponent();
        }

        private void employee_button_clicked(object sender, EventArgs e)
        {
            this.Show();
            admin_main employee = new admin_main();
            employee.Show();
        }

        private void ambulance_button_clicked(object sender, EventArgs e)
        {
            this.Hide();
            ambulance amb = new ambulance();
            amb.Show();
        }

        private void ctwo_report_clicked(object sender, EventArgs e)
        {
            this.Hide();
            analytic_report report = new analytic_report();
            report.Show();
        }

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
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
