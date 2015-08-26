using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            Data.Initialise();
            setButtons();
            timer1.Tick += (s, e) => setButtons();
            Text += Data.ConnectionString.Contains("Test") ? " TEST" : "";
        }

        private void setButtons()
        {
            grpKlokken.Enabled = Data.IsConnected;
            grpTotalen.Enabled = Data.IsConnected;
            btnClockIn.Enabled = !Data.IsLoggedIn();
            btnClockOut.Enabled = !btnClockIn.Enabled;            

            var reg = Data.Last();
            if (reg == null) return;
            lblOnline.Text = reg.checkOut == null ? "Aanwezig sinds " + reg.checkIn.ToShortTimeString() 
                + "    (" + reg.duration(DateTime.Now) + ")"
                : "Laatst uitklokt op " + ((DateTime)reg.checkOut).ToShortDateString() + " om " + ((DateTime)reg.checkOut).ToShortTimeString();
            lblUrenWeek.Text = Registratie.TotalDuration(Data.GetRegsForWeek()) + "/" + Contract.Uren;
            lblUrenTotaal.Text = Registratie.TotalDuration(Data.All());
            lblUrenDiff.Text = Registratie.Difference(Data.All());
            lblUrenDiff.ForeColor = lblUrenDiff.Text.StartsWith("+") ? Color.Green : Color.Red;
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {
            if (Data.CheckIn()) setButtons();
        }

        private void btnClockOut_Click(object sender, EventArgs e)
        {
            if (Data.CheckOut()) setButtons();
        }        

        private void lblOnline_Click(object sender, EventArgs e)
        {
            var form = new formEditTime();
            form.Show();
            form.FormClosing += (s, ea) => setButtons();
        }
    }
}
