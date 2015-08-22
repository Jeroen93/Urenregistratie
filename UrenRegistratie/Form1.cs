using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Data.Initialise();
            setButtons();
        }

        private void setButtons()
        {
            grpKlokken.Enabled = Data.IsConnected;
            grpTotalen.Enabled = Data.IsConnected;
            btnClockIn.Enabled = !Data.IsLoggedIn();
            btnClockOut.Enabled = !btnClockIn.Enabled;
            Text += Data.context.Connection.ConnectionString.Contains("Test") ? " TEST" : "";

            var reg = Data.Last();
            if (reg == null) return;
            lblOnline.Text = reg.checkOut == null ? "Aanwezig sinds " + reg.checkIn.ToShortTimeString() 
                + "    (" + reg.duration(DateTime.Now) + ")"
                : "Laatst uitklokt op " + ((DateTime)reg.checkOut).ToShortDateString() + " om " + ((DateTime)reg.checkOut).ToShortTimeString();
            lblUrenWeek.Text = Registratie.totalDuration(Data.GetRegsForWeek()) + "/" + Contract.Uren;
            lblUrenTotaal.Text = Registratie.totalDuration(Data.All());
            lblUrenDiff.Text = Registratie.difference(Data.All());
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            setButtons();
        }

        private void lblOnline_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Show();
            form.FormClosing += (s, ea) => setButtons();
        }
    }
}
