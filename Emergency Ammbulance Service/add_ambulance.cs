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
    public partial class add_ambulance : Form
    {
        public add_ambulance()
        {
            InitializeComponent();
        }

        private void add_ambulance_click(object sender, EventArgs e)
        {
            this.Hide();
            string plate_number = textBox1.Text;
            ambulance_vehicle amb = new ambulance_vehicle(plate_number, Status.Available);
            CRI cri = CRI.Instance;
            cri.add_ambulance(amb);
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
