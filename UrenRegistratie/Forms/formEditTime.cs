using System;
using System.Windows.Forms;
using UrenRegistratie.Layers;

namespace UrenRegistratie.Forms
{
    public partial class FormEditTime : Form
    {
        private DateTime _registration;
        private readonly DateTime _other;
        private Button _sender;

        public FormEditTime()
        {
            InitializeComponent();
            
            tmrButton.Tick += (s, e) =>
            {
                UpdateButtons();
                tmrButton.Interval = Math.Max(100, tmrButton.Interval / 2);
            };
            btnCancel.Click += (s, e) => Close();
            btnOk.Click += (s, e) => {
                if (Data.Update(_registration)) Close();
            };

            var reg = Data.Last();
            _registration = reg.CheckOut ?? reg.CheckIn;//Data.IsLoggedIn() ? reg.CheckIn : reg.CheckOut.Value;
            _other = !Data.IsLoggedIn() ? reg.CheckIn : (reg.CheckOut ?? DateTime.Now);
            SetTime(_registration);
        }

        private void ButtonDown(object sender, MouseEventArgs ea)
        {
            _sender = sender as Button;
            UpdateButtons();
            tmrButton.Interval = 1000;
            tmrButton.Start();
        }

        private void ButtonUp(object sender, MouseEventArgs ea)
        {
            tmrButton.Stop();
            _sender = null;
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

        private void UpdateButtons()
        {
            switch (_sender.Name)
            {
                case "btnMinUp":
                    Change(1);
                    break;
                case "btnMinDown":
                    Change(-1);
                    break;
                case "btnHourUp":
                    Change(60);
                    break;
                case "btnHourDown":
                    Change(-60);
                    break;
                default:
                    return;
            }
        }
    }
}
