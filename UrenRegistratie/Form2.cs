using System;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class Form2 : Form
    {
        private Registratie reg;
        private DateTime registration;
        private DateTime other;

        public Form2()
        {
            InitializeComponent();
            reg = Data.Last();
            registration = Data.IsLoggedIn() ? reg.checkIn : (DateTime)reg.checkOut;
            other = !Data.IsLoggedIn() ? reg.checkIn : (reg.checkOut.HasValue ? (DateTime)reg.checkOut : DateTime.Now);
            setTime(registration);
        }

        private void setTime(DateTime time)
        {
            var hrs = time.Hour;
            var min = time.Minute;
            lblHour.Text = (hrs < 10 ? "0" : "") + hrs;
            lblMin.Text = (min < 10 ? "0" : "") + min;
        }

        private void change(double value)
        {
            if (registration.AddMinutes(value).CompareTo(other) == (Data.IsLoggedIn() ? 1 : -1)) return;            
            registration = registration.AddMinutes(value);
            setTime(registration);
        }

        private void btnHourUp_Click(object sender, EventArgs e)
        {
            change(60);
        }

        private void btnHourDown_Click(object sender, EventArgs e)
        {
            change(-60);
        }

        private void btnMinUp_Click(object sender, EventArgs e)
        {
            change(1);
        }

        private void btnMinDown_Click(object sender, EventArgs e)
        {
            change(-1);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Data.Update(registration)) this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
