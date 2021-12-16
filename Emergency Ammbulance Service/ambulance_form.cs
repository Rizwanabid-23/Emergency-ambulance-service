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
    public partial class ambulance_form : Form
    {
        public ambulance_form()
        {
            InitializeComponent();
            showGrid();
        }

        public void showGrid()
        {
            CRI cri = CRI.Instance;
            ambulance_vehicle head = cri.get_amb_head();

            int total_ambs = 0;
            int ambs_work = 0;
            int ambs_available = 0;
            dataGridView1.Rows.Clear();
            while (head != null)
            {
                string number = head.number;
                Status status = head.status;
                
                dataGridView1.Rows.Add(number,status,null);
                if(status==Status.Available)
                {
                    ambs_available++;
                }
                else if(status==Status.Unavailable)
                {
                    ambs_work++;
                }
                total_ambs++;

                head = head.next;
            }
            total_ambulances_label.Text = total_ambs.ToString();
            work_ambulance_label.Text = ambs_work.ToString();
            available_ambulance_label.Text = ambs_available.ToString();
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
            ambulance_form ambulance = new ambulance_form();
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

        private void remove_ambulance_button_Click(object sender, EventArgs e)
        {

        }

        private void refresh_click(object sender, EventArgs e)
        {
            showGrid();
        }
    }
}
