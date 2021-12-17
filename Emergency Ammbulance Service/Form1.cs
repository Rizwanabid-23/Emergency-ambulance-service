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
    public partial class UpdateEmp : Form
    {
        Employee empName;
        public UpdateEmp(Employee nmae)
        {
            InitializeComponent();
            empName = nmae;
            label9.Visible = false;
            password_textbox.Visible = false;
            if (nmae != null)
            {
                showAttrib();
            }
            else { 
                MessageBox.Show("Nothing Select to update");
            }

        }
        private void showAttrib()
        {
           
            ID_textbox.Text = empName.id.ToString();
            name_textbox.Text = empName.name.ToString();
            phone_textbox.Text = empName.phone.ToString();
            cnic_textbox.Text = empName.CNIC.ToString();
            adress_textbox.Text = empName.address.ToString();
            employedas_combobox.Text = empName.type.ToString();
            shift_combobox.Text = empName.shift.ToString();
            if (empName.type == Type.CTWO)
            {
                label9.Visible = true;
                password_textbox.Visible = true;
                password_textbox.Text = empName.pin;
            }
            else
            {
                label9.Visible = true;
                password_textbox.Visible = true;
            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            admin_main ad = new admin_main();
            ad.view.PerformClick();
        }

        private void save_button_Click(object sender, EventArgs e)
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
                
                if (employedas_combobox.Text == "CTWO")
                {
                    empName.UpdateEmployee(id, name, rating, phone, cnic, adress, shift, Status.Unavailable, typ, password);
                }
                else
                {
                    empName.UpdateEmployee(id, name, rating, phone, cnic, adress, shift, Status.Unavailable, typ);
                }



                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            {
                string empId = ID_textbox.Text;
                foreach (var c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }
                ID_textbox.Text = empId;
            }
        }
    }
}
