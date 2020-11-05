namespace FrmColorPicker
{
    partial class FrmColorPicker
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Server = new System.Windows.Forms.TabPage();
            this.colorServerPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.colorClientPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCustomColor = new System.Windows.Forms.Button();
            this.txtClientBlue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtClientGreen = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClientRed = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnKirim = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIPClient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Server.SuspendLayout();
            this.colorServerPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Server);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // Server
            // 
            this.Server.Controls.Add(this.colorServerPanel);
            this.Server.Controls.Add(this.panel2);
            this.Server.Controls.Add(this.panel1);
            this.Server.Location = new System.Drawing.Point(4, 25);
            this.Server.Name = "Server";
            this.Server.Padding = new System.Windows.Forms.Padding(3);
            this.Server.Size = new System.Drawing.Size(583, 463);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server";
            this.Server.UseVisualStyleBackColor = true;
            // 
            // colorServerPanel
            // 
            this.colorServerPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.colorServerPanel.Controls.Add(this.panel4);
            this.colorServerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorServerPanel.Location = new System.Drawing.Point(3, 71);
            this.colorServerPanel.Name = "colorServerPanel";
            this.colorServerPanel.Size = new System.Drawing.Size(577, 389);
            this.colorServerPanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtBlue);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtGreen);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtRed);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 47);
            this.panel4.TabIndex = 0;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(442, 10);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(100, 22);
            this.txtBlue.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "B";
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(246, 10);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(100, 22);
            this.txtGreen.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "G";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(41, 10);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(100, 22);
            this.txtRed.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "R";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 30);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "SERVER";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListen);
            this.panel1.Controls.Add(this.txtIPServer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPortServer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 38);
            this.panel1.TabIndex = 0;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(452, 5);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(257, 6);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(169, 22);
            this.txtIPServer.TabIndex = 3;
            this.txtIPServer.Text = "192.168.0.105";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP";
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(80, 7);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(114, 22);
            this.txtPortServer.TabIndex = 1;
            this.txtPortServer.Text = "1678";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Port";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.colorClientPanel);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // colorClientPanel
            // 
            this.colorClientPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.colorClientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorClientPanel.Location = new System.Drawing.Point(3, 73);
            this.colorClientPanel.Name = "colorClientPanel";
            this.colorClientPanel.Size = new System.Drawing.Size(577, 284);
            this.colorClientPanel.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnCustomColor);
            this.panel7.Controls.Add(this.txtClientBlue);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.txtClientGreen);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.txtClientRed);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 357);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(577, 60);
            this.panel7.TabIndex = 3;
            // 
            // btnCustomColor
            // 
            this.btnCustomColor.Location = new System.Drawing.Point(455, 20);
            this.btnCustomColor.Name = "btnCustomColor";
            this.btnCustomColor.Size = new System.Drawing.Size(117, 23);
            this.btnCustomColor.TabIndex = 6;
            this.btnCustomColor.Text = "Custom Color";
            this.btnCustomColor.UseVisualStyleBackColor = true;
            this.btnCustomColor.Click += new System.EventHandler(this.btnCustomColor_Click);
            // 
            // txtClientBlue
            // 
            this.txtClientBlue.Location = new System.Drawing.Point(339, 20);
            this.txtClientBlue.Name = "txtClientBlue";
            this.txtClientBlue.ReadOnly = true;
            this.txtClientBlue.Size = new System.Drawing.Size(100, 22);
            this.txtClientBlue.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "B";
            // 
            // txtClientGreen
            // 
            this.txtClientGreen.Location = new System.Drawing.Point(183, 20);
            this.txtClientGreen.Name = "txtClientGreen";
            this.txtClientGreen.ReadOnly = true;
            this.txtClientGreen.Size = new System.Drawing.Size(100, 22);
            this.txtClientGreen.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(158, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "G";
            // 
            // txtClientRed
            // 
            this.txtClientRed.Location = new System.Drawing.Point(40, 20);
            this.txtClientRed.Name = "txtClientRed";
            this.txtClientRed.ReadOnly = true;
            this.txtClientRed.Size = new System.Drawing.Size(100, 22);
            this.txtClientRed.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "R";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnKirim);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 417);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(577, 43);
            this.panel6.TabIndex = 2;
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(497, 6);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 0;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(577, 31);
            this.panel5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "CLIENT";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtIPClient);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtPortClient);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 39);
            this.panel3.TabIndex = 0;
            // 
            // txtIPClient
            // 
            this.txtIPClient.Location = new System.Drawing.Point(283, 10);
            this.txtIPClient.Name = "txtIPClient";
            this.txtIPClient.Size = new System.Drawing.Size(208, 22);
            this.txtIPClient.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "IP";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(92, 10);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(100, 22);
            this.txtPortClient.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "No. Port";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // FrmColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmColorPicker";
            this.Text = "Color Picker";
            this.tabControl1.ResumeLayout(false);
            this.Server.ResumeLayout(false);
            this.colorServerPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Server;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel colorServerPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Panel colorClientPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIPClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtClientGreen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtClientRed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCustomColor;
        private System.Windows.Forms.TextBox txtClientBlue;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Timer timer1;
    }
}

