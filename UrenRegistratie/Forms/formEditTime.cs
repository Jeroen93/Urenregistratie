using System;
using System.Windows.Forms;
using UrenRegistratie.Layers;

namespace UrenRegistratie.Forms
{
    public partial class FormEditTime : Form
    {
        private DateTime _registration;
        private readonly DateTime _other;

        public FormEditTime()
        {
            InitializeComponent();

            //ButtonHandlers
            btnHourUp.Click += (s, e) => Change(60);
            btnHourDown.Click += (s, e) => Change(-60);
            btnMinUp.Click += (s, e) => Change(1);
            btnMinDown.Click += (s, e) => Change(-1);
            btnCancel.Click += (s, e) => Close();
            btnOk.Click += (s, e) => {
                if (Data.Update(_registration)) Close();
            };

            var reg = Data.Last();
            _registration = reg.CheckOut ?? reg.CheckIn;//Data.IsLoggedIn() ? reg.CheckIn : reg.CheckOut.Value;
            _other = !Data.IsLoggedIn() ? reg.CheckIn : (reg.CheckOut ?? DateTime.Now);
            SetTime(_registration);
        }

        private void SetTime(DateTime time)
        {
            var hrs = time.Hour;
            var min = time.Minute;
            lblHour.Text = (hrs < 10 ? "0" : "") + hrs;
            lblMin.Text = (min < 10 ? "0" : "") + min;
        }

        private void Change(double value)
        {
            if (_registration.AddMinutes(value).CompareTo(_other) == (Data.IsLoggedIn() ? 1 : -1)) return;            
            _registration = _registration.AddMinutes(value);
            SetTime(_registration);
        }
    }
}
