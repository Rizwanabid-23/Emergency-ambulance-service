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
    public partial class patient_info_form : Form
    {
        public patient_info_form()
        {
            InitializeComponent();
        }

        private void clear_click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PatientList p = PatientList.patInstance();
            string na = patient_name_textbox.Text;
            string co = patient_contact_textbox.Text;
            string cn = patient_cnic_textbox.Text;
            string ho = patient_hospital_textbox.Text;
            string re = reportedby_textbox.Text;
            PatientData pData = new PatientData(na, ho, re, co, cn);
            p.insert(pData);
            
        }
    }
}
