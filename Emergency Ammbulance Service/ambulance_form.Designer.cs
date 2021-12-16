
namespace Emergency_Ammbulance_Service
{
    partial class ambulance_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.log_out_button = new System.Windows.Forms.Button();
            this.call_logs_button = new System.Windows.Forms.Button();
            this.shift_button = new System.Windows.Forms.Button();
            this.ctwo_button = new System.Windows.Forms.Button();
            this.ambulance_button = new System.Windows.Forms.Button();
            this.employee_button = new System.Windows.Forms.Button();
            this.add_ambulance_button = new System.Windows.Forms.Button();
            this.total_ambulances_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.available_ambulance_label = new System.Windows.Forms.Label();
            this.work_ambulance_label = new System.Windows.Forms.Label();
            this.remove_ambulance_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plate_number_colomn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // log_out_button
            // 
            this.log_out_button.BackColor = System.Drawing.Color.FloralWhite;
            this.log_out_button.Location = new System.Drawing.Point(59, 364);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(108, 23);
            this.log_out_button.TabIndex = 54;
            this.log_out_button.Text = "Log Out";
            this.log_out_button.UseVisualStyleBackColor = false;
            this.log_out_button.Click += new System.EventHandler(this.log_out_click);
            // 
            // call_logs_button
            // 
            this.call_logs_button.AutoSize = true;
            this.call_logs_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.call_logs_button.Location = new System.Drawing.Point(59, 276);
            this.call_logs_button.Name = "call_logs_button";
            this.call_logs_button.Size = new System.Drawing.Size(108, 23);
            this.call_logs_button.TabIndex = 53;
            this.call_logs_button.Text = "Call logs";
            this.call_logs_button.UseVisualStyleBackColor = false;
            this.call_logs_button.Click += new System.EventHandler(this.call_log_clciked);
            // 
            // shift_button
            // 
            this.shift_button.AutoSize = true;
            this.shift_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shift_button.Location = new System.Drawing.Point(59, 237);
            this.shift_button.Name = "shift_button";
            this.shift_button.Size = new System.Drawing.Size(108, 23);
            this.shift_button.TabIndex = 52;
            this.shift_button.Text = "Shifts";
            this.shift_button.UseVisualStyleBackColor = false;
            this.shift_button.Click += new System.EventHandler(this.shift_clcik);
            // 
            // ctwo_button
            // 
            this.ctwo_button.AutoSize = true;
            this.ctwo_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctwo_button.Location = new System.Drawing.Point(59, 195);
            this.ctwo_button.Name = "ctwo_button";
            this.ctwo_button.Size = new System.Drawing.Size(108, 23);
            this.ctwo_button.TabIndex = 51;
            this.ctwo_button.Text = "CTWO reports";
            this.ctwo_button.UseVisualStyleBackColor = false;
            this.ctwo_button.Click += new System.EventHandler(this.ctwo_report_clicked);
            // 
            // ambulance_button
            // 
            this.ambulance_button.AutoSize = true;
            this.ambulance_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ambulance_button.Location = new System.Drawing.Point(59, 151);
            this.ambulance_button.Name = "ambulance_button";
            this.ambulance_button.Size = new System.Drawing.Size(108, 23);
            this.ambulance_button.TabIndex = 50;
            this.ambulance_button.Text = "Ambulance";
            this.ambulance_button.UseVisualStyleBackColor = false;
            this.ambulance_button.Click += new System.EventHandler(this.ambulance_click);
            // 
            // employee_button
            // 
            this.employee_button.AutoSize = true;
            this.employee_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employee_button.Location = new System.Drawing.Point(59, 108);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(108, 23);
            this.employee_button.TabIndex = 49;
            this.employee_button.Text = "Employee";
            this.employee_button.UseVisualStyleBackColor = false;
            this.employee_button.Click += new System.EventHandler(this.employee_click);
            // 
            // add_ambulance_button
            // 
            this.add_ambulance_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ambulance_button.Location = new System.Drawing.Point(339, 180);
            this.add_ambulance_button.Name = "add_ambulance_button";
            this.add_ambulance_button.Size = new System.Drawing.Size(116, 23);
            this.add_ambulance_button.TabIndex = 45;
            this.add_ambulance_button.Text = "Add new Ambulance";
            this.add_ambulance_button.UseVisualStyleBackColor = true;
            this.add_ambulance_button.Click += new System.EventHandler(this.add_ambulance_click);
            // 
            // total_ambulances_label
            // 
            this.total_ambulances_label.AutoSize = true;
            this.total_ambulances_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_ambulances_label.Location = new System.Drawing.Point(633, 76);
            this.total_ambulances_label.Name = "total_ambulances_label";
            this.total_ambulances_label.Size = new System.Drawing.Size(27, 20);
            this.total_ambulances_label.TabIndex = 40;
            this.total_ambulances_label.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Total Ambulances";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 40);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ambulance Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 27);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ambulance Service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Emergency";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(27)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 428);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Available Ambulances";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Ambulances at work";
            // 
            // available_ambulance_label
            // 
            this.available_ambulance_label.AutoSize = true;
            this.available_ambulance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available_ambulance_label.Location = new System.Drawing.Point(633, 142);
            this.available_ambulance_label.Name = "available_ambulance_label";
            this.available_ambulance_label.Size = new System.Drawing.Size(27, 20);
            this.available_ambulance_label.TabIndex = 57;
            this.available_ambulance_label.Text = "00";
            // 
            // work_ambulance_label
            // 
            this.work_ambulance_label.AutoSize = true;
            this.work_ambulance_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_ambulance_label.Location = new System.Drawing.Point(633, 110);
            this.work_ambulance_label.Name = "work_ambulance_label";
            this.work_ambulance_label.Size = new System.Drawing.Size(27, 20);
            this.work_ambulance_label.TabIndex = 58;
            this.work_ambulance_label.Text = "00";
            // 
            // remove_ambulance_button
            // 
            this.remove_ambulance_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_ambulance_button.Location = new System.Drawing.Point(461, 180);
            this.remove_ambulance_button.Name = "remove_ambulance_button";
            this.remove_ambulance_button.Size = new System.Drawing.Size(122, 23);
            this.remove_ambulance_button.TabIndex = 59;
            this.remove_ambulance_button.Text = "Remove Ambulance";
            this.remove_ambulance_button.UseVisualStyleBackColor = true;
            this.remove_ambulance_button.Click += new System.EventHandler(this.remove_ambulance_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plate_number_colomn,
            this.Status_column,
            this.driver_column});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(339, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(345, 192);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // plate_number_colomn
            // 
            this.plate_number_colomn.HeaderText = "Plate number";
            this.plate_number_colomn.Name = "plate_number_colomn";
            this.plate_number_colomn.ReadOnly = true;
            // 
            // Status_column
            // 
            this.Status_column.HeaderText = "Status";
            this.Status_column.Name = "Status_column";
            this.Status_column.ReadOnly = true;
            // 
            // driver_column
            // 
            this.driver_column.HeaderText = "Driver";
            this.driver_column.Name = "driver_column";
            this.driver_column.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(599, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.refresh_click);
            // 
            // ambulance_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(819, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.remove_ambulance_button);
            this.Controls.Add(this.work_ambulance_label);
            this.Controls.Add(this.available_ambulance_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.log_out_button);
            this.Controls.Add(this.call_logs_button);
            this.Controls.Add(this.shift_button);
            this.Controls.Add(this.ctwo_button);
            this.Controls.Add(this.ambulance_button);
            this.Controls.Add(this.employee_button);
            this.Controls.Add(this.add_ambulance_button);
            this.Controls.Add(this.total_ambulances_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ambulance_form";
            this.Text = "ambulance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button log_out_button;
        private System.Windows.Forms.Button call_logs_button;
        private System.Windows.Forms.Button shift_button;
        private System.Windows.Forms.Button ctwo_button;
        private System.Windows.Forms.Button ambulance_button;
        private System.Windows.Forms.Button employee_button;
        private System.Windows.Forms.Button add_ambulance_button;
        private System.Windows.Forms.Label total_ambulances_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label available_ambulance_label;
        private System.Windows.Forms.Label work_ambulance_label;
        private System.Windows.Forms.Button remove_ambulance_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate_number_colomn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver_column;
        private System.Windows.Forms.Button button1;
    }
}