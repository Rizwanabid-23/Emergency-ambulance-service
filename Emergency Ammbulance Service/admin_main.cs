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
        public ArrayList employee_list = new ArrayList();
        public admin_main()
        {
            InitializeComponent();
            File.AppendAllText("C:\\Users\\rizwa\\Documents\\GitHub\\DSA-G34\\dsa2021g34\\Emergency Ammbulance Service\\employee_data.txt", null);
            int line_no = File.ReadAllLines("C:\\Users\\rizwa\\Documents\\GitHub\\DSA-G34\\dsa2021g34\\Emergency Ammbulance Service\\employee_data.txt").Length;
            total_employees_label.Text = line_no.ToString();

            show_grid();
        }

        private void show_grid()
        {
            //foreach(CTWO i in employee_list)
            //{
            //    dataGridView1.Rows.Add(i.Id,i.Name,i.);
            //}
            
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
    }
}
