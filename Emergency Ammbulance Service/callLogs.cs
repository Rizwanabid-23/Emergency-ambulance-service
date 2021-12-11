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
    public partial class callLogs : Form
    {
        public callLogs()
        {
            InitializeComponent();
        }

        private void employee_clicked(object sender, EventArgs e)
        {
            this.Hide();
            admin_main employee = new admin_main();
            employee.Show();
        }

        private void ambulance_clicked(object sender, EventArgs e)
        {
            this.Hide();
            ambulance amb = new ambulance();
            amb.Show();

        }

        private void ctwo_clicked(object sender, EventArgs e)
        {
            this.Hide();
            analytic_report report = new analytic_report();
            report.Show();
        }

        private void shift_clicked(object sender, EventArgs e)
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

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if(c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }
    }
}
