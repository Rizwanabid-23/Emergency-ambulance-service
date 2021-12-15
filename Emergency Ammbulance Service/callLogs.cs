using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Emergency_Ammbulance_Service
{
    public partial class callLogs : Form
    {
        public callLogs()
        {
            InitializeComponent();
        }

        private void employee_clicked(object sender, EventArgs e)
        {
            this.Hide();
            admin_main employee = new admin_main();
            employee.Show();
        }

        private void ambulance_clicked(object sender, EventArgs e)
        {
            this.Hide();
            ambulance_form amb = new ambulance_form();
            amb.Show();

        }

        private void ctwo_clicked(object sender, EventArgs e)
        {
            this.Hide();
            analytic_report report = new analytic_report();
            report.Show();
        }

        private void shift_clicked(object sender, EventArgs e)
        {
            this.Hide();
            shifts shifts = new shifts();
            shifts.Show();
        }

        private void call_log_clciked(object sender, EventArgs e)
        {
            this.Hide();
            callLogs log = new callLogs();
            log.Show();
        }

        private void log_out(object sender, EventArgs e)
        {
            this.Hide();
            loginForm login = new loginForm();
            login.Show();
        }

        private void clear_clicked(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                if(c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

        private void callLogs_Load(object sender, EventArgs e)
        {
            load_call();
        }
        public void load_call()
        {
             string caller;
             string number;
             string time;
             string Duration;
             string location;
             string Emergencycode;
             string patient;
             string action;
             string verified;
             string CTWO;
        string[] lines = File.ReadAllLines("employee_data.txt");
            Stack stack = Stack.Instance;
            foreach (string line in lines)
            {
                caller = getStr(line, 0);
                number = getStr(line, 1);
                time =  getStr(line, 2);
                Duration = getStr(line, 3);
                location = getStr(line, 4);
                Emergencycode = getStr(line, 5);
                patient = getStr(line, 6);
                verified = getStr(line, 7);
                action = getStr(line, 8);
                CTWO = getStr(line, 9);
                Call call = new Call(caller, number,time, Duration, location, Emergencycode, patient, verified, action, CTWO);
                stack.push(int.Parse(Emergencycode),call);
            }
        }
        private string getStr(string statement, int position)
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

    }
}
