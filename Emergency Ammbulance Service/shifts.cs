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
            show_Emp();
        }

        public int employee_counter = 0;
        public int morning_counter = 0;
        public int evening_counter = 0;
        public int night_counter = 0;

        public void show_Emp()
        {
            CRI cRI = CRI.Instance;
            Employee head = cRI.gethead();
            Employee y = head;
            int id, rating, phone;
            Type type;
            Shift shft;
            dataGridView1.Rows.Clear();
            employee_counter = 0;
            while (y != null)
            {
                id = y.id;
                Name = y.name;
                rating = 0;
                type = y.type;
                shft = y.shift;
                dataGridView1.Rows.Add(id, Name, rating, type, shft);
                
                employee_counter++;
                if(y.shift==Shift.Morning)
                {
                    morning_counter++;
                }
                else if(y.shift==Shift.Evening)
                {
                    evening_counter++;
                }
                else if(y.shift==Shift.Night)
                {
                    night_counter++;
                }
                y = y.next;
            }
            total_employees_label.Text = employee_counter.ToString();
            label7.Text = morning_counter.ToString();
            label8.Text = evening_counter.ToString();
            label10.Text = night_counter.ToString();
        }
        private void employee_click(object sender, EventArgs e)
        {
            this.Hide();
            admin_main employee = new admin_main();
            employee.Show();
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

        private void search_click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string key = search_textbox.Text;
            string column = column_comboBox.Text;
            CRI cri = CRI.Instance;
            Employee lst = cri.searchEmployee(column, key);

            try
            {
                dataGridView1.Rows.Add(lst.id, lst.name, lst.rating, lst.type, lst.shift);
            }
            catch (NullReferenceException m)
            {
                MessageBox.Show("Found Nothing ");
            }
        }
    }
}
