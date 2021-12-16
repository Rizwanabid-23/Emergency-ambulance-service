using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Emergency_Ammbulance_Service
{
    public partial class admin_main : Form
    {
        string name = "";
        Employee emp;
        CRI cri = CRI.Instance;
        public admin_main()
        {
            InitializeComponent();

        }



        public void show_Emp()
        {
            
            EmpList lst = EmpList.Instance;
            Employee y = lst.head;
            int id, rating, phone;
            Type type;
            Shift shft;
            dataGridView1.Rows.Clear();
            int employee_counter = 0;
            while (y != null)
            {
                id = y.id;
                Name = y.name;
                rating = 0;
                phone = y.phone;
                type = y.type;
                shft = y.shift;
                dataGridView1.Rows.Add(id, Name, rating, type, shft , phone, y.pin);
                y = y.next;
                employee_counter++;
            }
            total_employees_label.Text = employee_counter.ToString();
        }

        

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.Show();
        }

        private void add_employee(object sender, EventArgs e)
        {
            add_employees emp = new add_employees();
            emp.Show();
        }

        private void employee_button(object sender, EventArgs e)
        {
            this.Hide();
            admin_main ad = new admin_main();
            ad.Show();
        }

        private void clear_filters(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex=-1;
                }
            }
        }

        private void admin_main_Load(object sender, EventArgs e)
        {
            show_Emp();
        }

        private void view_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            show_Emp();
        }

        private void ambulance_clcik(object sender, EventArgs e)
        {
            this.Hide();
            ambulance_form amb = new ambulance_form();
            amb.Show();
        }

        private void ctwo_report_clcik(object sender, EventArgs e)
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

        private void call_log_clicked(object sender, EventArgs e)
        {
            this.Show();
            callLogs log = new callLogs();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            string key = searchKey.Text;
            string col = searchBy.Text;
            CRI cri = CRI.Instance;
            Employee lst = cri.searchEmployee(col, key);

            try
            {               
                dataGridView1.Rows.Add(lst.id, lst.name, 0, lst.type, lst.shift, lst.phone, lst.pin);
            }
            catch (NullReferenceException m)
            {
                MessageBox.Show("Found Nothing ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            
            if (rowindex >= 0)
            {          
                name = dataGridView1.Rows[rowindex].Cells["nameColumn"].Value.ToString();
            }
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            emp = cri.searchEmployee("Name",name);
            UpdateEmp updateEmp =  new UpdateEmp(emp);
            updateEmp.Show();
            updateEmp.BringToFront();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            emp = cri.searchEmployee("Name", name);
            bool del = cri.delete(emp);
            if (del)
            {
                MessageBox.Show("Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Not found!");
            }
            view.PerformClick();
        }
    }
}
