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
        ambulance_list lst = ambulance_list.vehichleInstance();
        string plate;
        
        public ambulance_form()
        {
            InitializeComponent();
            total_ambulances_label.Text = lst.size().ToString();
            showGrid();


        }

        public void showGrid()
        {
            CRI cri = CRI.Instance;
            ambulance_vehicle head = cri.get_amb_head();
            
            dataGridView1.Rows.Clear();
            while (head != null)
            {
                string number = head.number;
                Status status = head.status;
                
                dataGridView1.Rows.Add(number,status,null);
                head = head.next;
            }
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
            
            if(lst.delete(plate))
            {
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void refresh_click(object sender, EventArgs e)
        {
            total_ambulances_label.Text = lst.size().ToString();
            showGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            if (rowindex >= 0)
            {
                plate = dataGridView1.Rows[rowindex].Cells["plate_number_colomn"].Value.ToString();

            }
            
        }
    }
}
