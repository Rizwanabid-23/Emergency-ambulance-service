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
            counter_id = File.ReadAllLines("C:\\Users\\rizwa\\Documents\\GitHub\\DSA-G34\\dsa2021g34\\Emergency Ammbulance Service\\employee_data.txt").Length;
            ID_textbox.Text = counter_id.ToString();
            counter_id++;
        }
        

        private void save_employee_info(object sender, EventArgs e)
        {
            int id = int.Parse(ID_textbox.Text);
            string name = name_textbox.Text;
            int rating = 0;
            int phone = int.Parse(phone_textbox.Text);
            int cnic = int.Parse(cnic_textbox.Text);
            string adress = adress_textbox.Text;
            string shift = shift_combobox.Text;
            string employed_as = employedas_combobox.Text;
            string password = password_textbox.Text;

            
            CTWO employee = new CTWO(id, name, rating, phone, cnic, adress, shift, employed_as, password);
            File.AppendAllText("C:\\Users\\rizwa\\Documents\\GitHub\\DSA-G34\\dsa2021g34\\Emergency Ammbulance Service\\employee_data.txt", null);
            var data = employee.Id + "," + employee.Name + "," + employee.Rating + "," + employee.Phone + "," + employee.Cnic + "," + employee.Adress + "," + employee.Shift + "," + employee.Employed_as + "," + employee.Password;
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
