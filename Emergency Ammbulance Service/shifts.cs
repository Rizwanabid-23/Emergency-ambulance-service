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
    public partial class shifts : Form
    {
        public shifts()
        {
            InitializeComponent();
        }

        private void employee_click(object sender, EventArgs e)
        {
            this.Hide();
            admin_main employee = new admin_main();
            employee.show_Emp();
        }

        private void ambulance_click(object sender, EventArgs e)
        {
            this.Hide();
            ambulance_form amb = new ambulance_form();
            amb.Show();
        }

        private void ctwo_click(object sender, EventArgs e)
        {
            this.Hide();
            analytic_report report = new analytic_report();
            report.Show();
        }

        private void shift_click(object sender, EventArgs e)
        {
            this.Hide();
            shifts shift = new shifts();
            shift.Show();
        }

        private void call_logs(object sender, EventArgs e)
        {
            this.Hide();
            callLogs logs = new callLogs();
            logs.Show();
        }

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm form = new loginForm();
            form.Show();
        }
    }
}
