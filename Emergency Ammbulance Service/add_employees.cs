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

namespace Emergency_Ammbulance_Service
{
    public partial class add_employees : Form
    {
        public static int counter_id=0;
        public add_employees()
        {
            InitializeComponent();
            counter_id = File.ReadAllLines("employee_data.txt").Length;
            ID_textbox.Text = counter_id.ToString();
            password_textbox.Visible = false;
            label9.Visible = false;
            counter_id++;
        }
        

        private void save_employee_info(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(ID_textbox.Text);
                string name = name_textbox.Text;
                int rating = 0;
                int phone = int.Parse(phone_textbox.Text);
                int cnic = int.Parse(cnic_textbox.Text);
                string adress = adress_textbox.Text;
                string shf = shift_combobox.Text;
                Shift shift;
                Enum.TryParse(shf, out shift);
                string employed_as = employedas_combobox.Text;
                Type typ;
                Enum.TryParse(employed_as, out typ);
                string password = password_textbox.Text;
                Employee emp;
                if (employedas_combobox.Text == "CTWO")
                {
                   emp = new Employee(id, name, rating, phone, cnic, adress, shift, Status.Unavailable, typ, password);
                }
                else
                {
                    emp = new Employee(id, name, rating, phone, cnic, adress, shift, Status.Unavailable, typ);
                }

                
                CRI cri = CRI.Instance;
                cri.add_employee(emp);

                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void clear_textbox(object sender, EventArgs e)
        {
            {
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
            }
        }

        private void employedas_combobox_TextUpdate(object sender, EventArgs e)
        {
            if (employedas_combobox.Text == "CTWO")
            {
                password_textbox.Visible = true;
                label9.Visible = true;

            }
            else
            {
                password_textbox.Visible = false;
                label9.Visible = false;
            }
        }
    }
}
