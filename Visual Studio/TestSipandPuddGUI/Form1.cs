using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestSipandPuddGUI
{
    public partial class Calibration : Form
    {
        public delegate void b1(int level);
        public Calibration()
        {
            InitializeComponent();
            SipnPuff.Open();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SipnPuff_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {   //receives a int 0-100 for puff strength
            int level = 0;
            Int32.TryParse(SipnPuff.ReadLine(), out level);


            b1 writeit = new b1(Write2Bar);
            Invoke(writeit, level);

        }

        public void Write2Bar(int level)
        {   //writes the strength to the bar
            if (level >= 0)
            {
                PuffBar.Value = level;
                SipBar.Value = 0;

            }
            else if (level < 0)
            {
                SipBar.Value = -level;
                PuffBar.Value = 0;
            }
            else
            {
                SipBar.Value = 0;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //SipnPuff.Close();
            List<Patient> pat = new List<Patient>();
            pat.Add(new Patient()
            {
                ID = int.Parse(IDnum.Text),
                SipThreshold = int.Parse(SipThreshold.Text),
                PuffThreshold = int.Parse(PuffThreshold.Text),
            });

            string JSONresult = JsonConvert.SerializeObject(pat.ToArray());
            var path = string.Format(@"D:\json\{0}.json", int.Parse(IDnum.Text));

            FileInfo fi = new FileInfo(path);
            DirectoryInfo di = new DirectoryInfo(@"D:\json\");

            //write string to file
            if (!di.Exists)
            {
                di.Create();
            }
            if (!fi.Exists)
            {
                using (FileStream fs = File.Create(path));
            }
            System.IO.File.WriteAllText(path, JSONresult);
        }

        private void PuffCalebrationBar_Scroll_1(object sender, EventArgs e)
        {
            PuffThreshold.Text = PuffCalebrationBar.Value.ToString();
        }

        private void SipCalebrationBar_Scroll_1(object sender, EventArgs e)
        {
            SipThreshold.Text = SipCalebrationBar.Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SipnPuff.Write("Sip Threshold:\n");
            SipnPuff.Write(SipThreshold.Text);
            SipnPuff.Write("\n");
            SipnPuff.Write("Puff Threshold:\n");
            SipnPuff.Write(PuffThreshold.Text);
            SipnPuff.Write("\n");
        }
    }
}


                
            
    

