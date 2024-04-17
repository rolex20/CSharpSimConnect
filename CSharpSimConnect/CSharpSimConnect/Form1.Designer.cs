namespace SimConnect3
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnect = new Button();
            lblAircraftName = new Label();
            label2 = new Label();
            label1 = new Label();
            lblTrueAirspeed = new Label();
            label4 = new Label();
            lblFlapsStatus = new Label();
            label6 = new Label();
            lblAirbrakesStatus = new Label();
            label3 = new Label();
            lblTimestamp = new Label();
            btnDisconnect = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(56, 80);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblAircraftName
            // 
            lblAircraftName.AutoSize = true;
            lblAircraftName.Location = new Point(183, 127);
            lblAircraftName.Name = "lblAircraftName";
            lblAircraftName.Size = new Size(38, 15);
            lblAircraftName.TabIndex = 1;
            lblAircraftName.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 127);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 2;
            label2.Text = "AircraftName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 169);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 4;
            label1.Text = "TrueAirspeed(knots)";
            // 
            // lblTrueAirspeed
            // 
            lblTrueAirspeed.AutoSize = true;
            lblTrueAirspeed.Location = new Point(183, 169);
            lblTrueAirspeed.Name = "lblTrueAirspeed";
            lblTrueAirspeed.Size = new Size(38, 15);
            lblTrueAirspeed.TabIndex = 3;
            lblTrueAirspeed.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 212);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Flaps (%)";
            // 
            // lblFlapsStatus
            // 
            lblFlapsStatus.AutoSize = true;
            lblFlapsStatus.Location = new Point(183, 212);
            lblFlapsStatus.Name = "lblFlapsStatus";
            lblFlapsStatus.Size = new Size(38, 15);
            lblFlapsStatus.TabIndex = 5;
            lblFlapsStatus.Text = "label1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 254);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 8;
            label6.Text = "Airbrake (%)";
            // 
            // lblAirbrakesStatus
            // 
            lblAirbrakesStatus.AutoSize = true;
            lblAirbrakesStatus.Location = new Point(183, 254);
            lblAirbrakesStatus.Name = "lblAirbrakesStatus";
            lblAirbrakesStatus.Size = new Size(101, 15);
            lblAirbrakesStatus.TabIndex = 7;
            lblAirbrakesStatus.Text = "lblAirbrakesStatus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 292);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 9;
            label3.Text = "Timestamp:";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Location = new Point(183, 292);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(38, 15);
            lblTimestamp.TabIndex = 10;
            lblTimestamp.Text = "label5";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Enabled = false;
            btnDisconnect.Location = new Point(158, 80);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(108, 23);
            btnDisconnect.TabIndex = 11;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 39);
            label5.Name = "label5";
            label5.Size = new Size(274, 15);
            label5.TabIndex = 12;
            label5.Text = "Hint: Start MSFS before and then click on Connect.";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 356);
            Controls.Add(label5);
            Controls.Add(btnDisconnect);
            Controls.Add(lblTimestamp);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(lblAirbrakesStatus);
            Controls.Add(label4);
            Controls.Add(lblFlapsStatus);
            Controls.Add(label1);
            Controls.Add(lblTrueAirspeed);
            Controls.Add(label2);
            Controls.Add(lblAircraftName);
            Controls.Add(btnConnect);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmMain";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "SimConnect and C#";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Label lblAircraftName;
        private Label label2;
        private Label label1;
        private Label lblTrueAirspeed;
        private Label label4;
        private Label lblFlapsStatus;
        private Label label6;
        private Label lblAirbrakesStatus;
        private Label label3;
        private Label lblTimestamp;
        private Button btnDisconnect;
        private Label label5;
    }
}
