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
    public partial class dispatch_ambulance : Form
    {

        Employee Driver;
        Employee EMT;
        EmpList eList = EmpList.Instance;
        ambulance_vehicle v;
        public dispatch_ambulance()
        {
            InitializeComponent();
        }

        private void id_label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        public void show_Available_Emt()
        {

            EmpList lst = EmpList.Instance;
            List<Employee> eList = lst.getAvailableList(Type.EMT);
            int employee_counter = 0;
            
            emtForDIspatch.Rows.Clear();
            foreach (Employee e in eList)
            {           
            
                emtForDIspatch.Rows.Add(e.id, e.name);
                employee_counter++;
            }
            totalEmt.Text = employee_counter.ToString();
        }
        public void show_Available_Driver()
        {
            EmpList lst = EmpList.Instance;
            List<Employee> eList = lst.getAvailableList(Type.Driver);
            
            int employee_counter = 0;
            foreach (Employee e in eList)
            {
                driverForDispatch.Rows.Add(e.id, e.name);
                employee_counter++;
            }
            availableDriver.Text = employee_counter.ToString();
        }



        private void dispatch_ambulance_Load(object sender, EventArgs e)
        {
            ambulance_Queue q = ambulance_Queue.vehichleQueueInstance();
            v =  q.dispatchAmbulance();
            selectedVehichle.Text = v.number;
            show_Available_Emt();
            show_Available_Driver();
        }

        private void emtForDIspatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = emtForDIspatch.CurrentCell.RowIndex;
            if (rowindex >= 0)
            {
                selectedEmt.Text = emtForDIspatch.Rows[rowindex].Cells["nameEMT"].Value.ToString();
                EMT = eList.searchEmp(selectedEmt.Text);
                eList.updateStatusToUnAvailable(selectedEmt.Text);


            }
        }

        private void driverForDispatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpList lst = EmpList.Instance;
            int rowindex = driverForDispatch.CurrentCell.RowIndex;

            if (rowindex >= 0)
            {
                selectedDriver.Text = driverForDispatch.Rows[rowindex].Cells["status_driver_column"].Value.ToString();
                Driver = eList.searchEmp(selectedDriver.Text);
                lst.updateStatusToUnAvailable(selectedDriver.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.setDriver(Driver);
            v.setEmT(EMT);
        }
    }
}
