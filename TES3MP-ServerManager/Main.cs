using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TES3MP_ServerManager
{
    public partial class Main : Form
    {
        //IP list for listbox
        public static List<string> IPs = new List<string>();
        public Main()
        {
            InitializeComponent();
            InitMain();
        }

        //Create DIRs if not there and Init/Load Address file
        void InitMain()
        {
            InitDIR();
            LoadIPs();
        }

        void InitDIR()
        {
            FileIO.InitDIR();
        }

        void LoadIPs()
        {
            FileIO.LoadIP();
            LBIPs.DataSource = IPs;
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (TBIP.Text != "")
            {
                FileIO.SaveIP(TBIP.Text);
                LBIPs.DataSource = null;
                LBIPs.DataSource = IPs;
            }
            else
            {
                Error("No IP entered.");
            }
        }

        //Delete selected IP from list and file
        private void BDelete_Click(object sender, EventArgs e)
        {
            if (LBIPs.SelectedItem != null)
            {
                FileIO.DeleteIP(Convert.ToString(LBIPs.SelectedItem));
                LBIPs.DataSource = null;
                LBIPs.DataSource = IPs;
            }
            else
            {
                Error("No IP selected.");
            }
        }

        //Run TES3MP with selected IP
        private void BConnect_Click(object sender, EventArgs e)
        {
            if (LBIPs.SelectedItem != null && FileIO.ProcessCheck())
            {
                FileIO.Run(Convert.ToString(LBIPs.SelectedItem));
            }
            else if(LBIPs.SelectedItem == null)
            {
                Error("Cannot load TES3MP without a selected IP.");
            }
            else if (!FileIO.ProcessCheck())
            {
                Error("tes3mp.exe not found.");
            }
        }

        //Lazy error message function because typing MessageBox.Show and "ERROR" is simply too much work
        private void Error(string i)
        {
            MessageBox.Show(i, "ERROR");
        }

        //Catch Enter press
        private void TBIP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if (TBIP.Text != "")
                {
                    FileIO.SaveIP(TBIP.Text);
                    LBIPs.DataSource = null;
                    LBIPs.DataSource = IPs;
                }
                else
                {
                    Error("No IP entered.");
                }
            }
        }
    }
}
