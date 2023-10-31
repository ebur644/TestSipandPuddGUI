namespace TestSipandPuddGUI
{
    partial class Calibration
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
            this.SipnPuff = new System.IO.Ports.SerialPort(this.components);
            this.SipCalebrationBar = new System.Windows.Forms.TrackBar();
            this.PuffBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SipBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PuffCalebrationBar = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.IDnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.SipThreshold = new System.Windows.Forms.TextBox();
            this.PuffThreshold = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SipCalebrationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuffCalebrationBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SipnPuff
            // 
            this.SipnPuff.PortName = "COM4";
            this.SipnPuff.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SipnPuff_DataReceived);
            // 
            // SipCalebrationBar
            // 
            this.SipCalebrationBar.Location = new System.Drawing.Point(115, 163);
            this.SipCalebrationBar.Name = "SipCalebrationBar";
            this.SipCalebrationBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SipCalebrationBar.RightToLeftLayout = true;
            this.SipCalebrationBar.Size = new System.Drawing.Size(280, 56);
            this.SipCalebrationBar.TabIndex = 0;
            this.SipCalebrationBar.Scroll += new System.EventHandler(this.SipCalebrationBar_Scroll_1);
            // 
            // PuffBar
            // 
            this.PuffBar.BackColor = System.Drawing.SystemColors.Window;
            this.PuffBar.Location = new System.Drawing.Point(393, 196);
            this.PuffBar.Name = "PuffBar";
            this.PuffBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PuffBar.Size = new System.Drawing.Size(280, 23);
            this.PuffBar.TabIndex = 1;
            this.PuffBar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(423, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soft Puff Threshold";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SipBar
            // 
            this.SipBar.Location = new System.Drawing.Point(115, 196);
            this.SipBar.Name = "SipBar";
            this.SipBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SipBar.RightToLeftLayout = true;
            this.SipBar.Size = new System.Drawing.Size(280, 23);
            this.SipBar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(147, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soft Sip Threshold";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PuffCalebrationBar
            // 
            this.PuffCalebrationBar.Location = new System.Drawing.Point(393, 163);
            this.PuffCalebrationBar.Name = "PuffCalebrationBar";
            this.PuffCalebrationBar.Size = new System.Drawing.Size(280, 56);
            this.PuffCalebrationBar.TabIndex = 6;
            this.PuffCalebrationBar.Scroll += new System.EventHandler(this.PuffCalebrationBar_Scroll_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zero";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // IDnum
            // 
            this.IDnum.Location = new System.Drawing.Point(68, 59);
            this.IDnum.Name = "IDnum";
            this.IDnum.Size = new System.Drawing.Size(100, 22);
            this.IDnum.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patient Number:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save Configuration Settings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SipThreshold
            // 
            this.SipThreshold.Location = new System.Drawing.Point(203, 254);
            this.SipThreshold.Name = "SipThreshold";
            this.SipThreshold.Size = new System.Drawing.Size(100, 22);
            this.SipThreshold.TabIndex = 11;
            // 
            // PuffThreshold
            // 
            this.PuffThreshold.Location = new System.Drawing.Point(483, 254);
            this.PuffThreshold.Name = "PuffThreshold";
            this.PuffThreshold.Size = new System.Drawing.Size(100, 22);
            this.PuffThreshold.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Upload Configuration";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.PuffThreshold);
            this.Controls.Add(this.SipThreshold);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDnum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SipBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PuffBar);
            this.Controls.Add(this.SipCalebrationBar);
            this.Controls.Add(this.PuffCalebrationBar);
            this.Name = "Calibration";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SipCalebrationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuffCalebrationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort SipnPuff;
        private System.Windows.Forms.TrackBar SipCalebrationBar;
        private System.Windows.Forms.ProgressBar PuffBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar SipBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar PuffCalebrationBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IDnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox SipThreshold;
        private System.Windows.Forms.TextBox PuffThreshold;
        private System.Windows.Forms.Button button4;
    }
}

