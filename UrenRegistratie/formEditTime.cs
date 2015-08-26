using System;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class formEditTime : Form
    {
        private Registratie reg;
        private DateTime registration;
        private DateTime other;

        public formEditTime()
        {
            InitializeComponent();

            //ButtonHandlers
            btnHourUp.Click += (s, e) => change(60);
            btnHourDown.Click += (s, e) => change(-60);
            btnMinUp.Click += (s, e) => change(1);
            btnMinDown.Click += (s, e) => change(-1);
            btnCancel.Click += (s, e) => this.Close();
            btnOk.Click += (s, e) => {
                if (Data.Update(registration)) this.Close();
            };

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
    }
}
