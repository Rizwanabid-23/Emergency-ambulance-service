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
        public admin_main()
        {
            InitializeComponent();
            
        

        }

        public void show_Emp()
        {
            CRI cRI = CRI.Instance;
            Employee head = cRI.head();
            Employee y = head;
            int id, rating, phone;
            Type type;
            Shift shft;
            while (y != null)
            {
                id = y.id;
                Name = y.name;
                rating = 0;
                phone = y.phone;
                type = y.type;
                shft = y.shift;
                dataGridView1.Rows.Add(id, Name, rating, type, shft , phone);
                y = y.next;
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

        private void admin_main_Load(object sender, EventArgs e)
        {
            show_Emp();
        }

        private void view_Click(object sender, EventArgs e)
        {
            show_Emp();
        }
    }
}
