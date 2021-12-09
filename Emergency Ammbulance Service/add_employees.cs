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
        admin_main admin_CRI = new admin_main();
        public add_employees()
        {
            InitializeComponent();
        }
        

        private void save_employee_info(object sender, EventArgs e)
        {
            string id = ID_textbox.Text;
            string name = name_textbox.Text;
            string phone = phone_textbox.Text;
            string cnic = cnic_textbox.Text;
            string adress = adress_textbox.Text;
            string shift = shift_combobox.Text;
            string employed_as = employedas_combobox.Text;
            string password = password_textbox.Text;

            
            CTWO employee = new CTWO(id, name, phone, cnic, adress, shift, employed_as, password);
            admin_CRI.employee_list.Add(employee);
            File.AppendAllText("C:\\Users\\rizwa\\Documents\\GitHub\\DSA-G34\\dsa2021g34\\Emergency Ammbulance Service\\employee_data.txt", null);
            var data = employee.Id + "," + employee.Name + "," + employee.Phone + "," + employee.Cnic + "," + employee.Adress + "," + employee.Shift + "," + employee.Employed_as + "," + employee.Password;
            File.AppendAllText("C:\\Users\\rizwa\\Documents\\GitHub\\DSA-G34\\dsa2021g34\\Emergency Ammbulance Service\\employee_data.txt", data + "\n");

            this.Hide();
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
    }
}
