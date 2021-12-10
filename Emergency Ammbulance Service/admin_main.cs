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
            string[] lines = File.ReadAllLines("C:\\Users\\rizwa\\Documents\\GitHub\\DSA-G34\\dsa2021g34\\Emergency Ammbulance Service\\employee_data.txt");
            foreach (string line in lines)
            {
                int id = int.Parse(get_ID(line, 0));
                string name = get_ID(line, 1);
                int rating = int.Parse(get_ID(line, 2));
                int phone = int.Parse(get_ID(line, 3));
                int cnic = int.Parse(get_ID(line, 4));
                string adress = get_ID(line, 5);
                string shift = get_ID(line, 6);
                string position = get_ID(line, 7);
                string password = get_ID(line, 8);

                CTWO employee = new CTWO(id, name, rating, phone, cnic, adress, shift, position, password);
                employee_list.Add(employee);
            }


            foreach (CTWO i in employee_list)
            {
                dataGridView1.Rows.Add(i.Id, i.Name, i.Rating, i.Employed_as, i.Shift, i.Phone);
            }

        }

        private string get_ID(string statement, int position)
        {
            int idx = 0;
            int comma = 0;
            string word = "";
            while (idx < statement.Length)
            {
                char c = statement[idx];
                if (c == ',')
                {
                    comma++;
                }
                else if (comma == position)
                {
                    word = word + c;
                }
                idx++;
            }
            return word;
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
