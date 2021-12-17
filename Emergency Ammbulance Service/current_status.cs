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
    public partial class current_status : Form
    {
        public current_status()
        {
            InitializeComponent();
        }
        int counter_time = 10;

        private void receive_patient_click(object sender, EventArgs e)
        {
            patient_info_form form = new patient_info_form();
            form.Show();
        }

        private void receive_ambulance_click(object sender, EventArgs e)
        {
            string number=textBox1.Text;
            ambulance_Queue q = ambulance_Queue.vehichleQueueInstance();
            q.addAmbulance(number);
        }

        private void profile_click(object sender, EventArgs e)
        {
            this.Hide();
            employee_main profile = new employee_main();
            profile.Show();
        }

        private void call_center_click(object sender, EventArgs e)
        {
            this.Hide();
            call_center call_Center = new call_center();
            call_Center.Show();
        }

        private void current_status_click(object sender, EventArgs e)
        {
            this.Hide();
            current_status status = new current_status();
            status.Show();
        }

        private void parking_click(object sender, EventArgs e)
        {
            this.Hide();
            parking park = new parking();
            park.Show();

        }

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm form = new loginForm();
            form.Show();
        }

        private void log_click(object sender, EventArgs e)
        {
            this.Hide();
            callLogs logs = new callLogs();
            logs.Show();
        }
        private void show_time()
        {
            string time= "11:" + counter_time.ToString();
            label10.Text = time;
            counter_time+=10;
            CRI cri = CRI.Instance;
            ambulance_vehicle head = cri.get_amb_head();
            int amb_counter = 0;
            while (head != null)
            {
                head = head.next;
                amb_counter++;
            }
            label12.Text = amb_counter.ToString();

            EmpList lst = EmpList.Instance;
            int allDriver = lst.getTotal(Type.Driver);
            label11.Text = allDriver.ToString();

            int allHelper = lst.getTotal(Type.EMT);
            label15.Text = allHelper.ToString();

        }

        private void time_changer(object sender, EventArgs e)
        {
            show_time();
        }
    }
}
