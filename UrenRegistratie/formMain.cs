using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
// ReSharper disable LocalizableElement

namespace UrenRegistratie
{
    public sealed partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Data.Initialise();
            SetForm();
            if (Data.ConnectionString.Contains("Test")) Text += " TEST";

            timer1.Tick += (s, e) => SetForm();
            FormClosing += (s, e) => Data.CloseConnection();
            btnClockIn.Click += (s, e) => OpenForm(new FormLoc());
            btnClockOut.Click += (s, e) => { if (Data.CheckOut()) SetForm(); };
            lblOnline.Click += (s, e) => OpenForm(new FormEditTime());
            dtOverzicht.ValueChanged += (s, e) => SetBtnGenerate();            
            chrtUren.Series[1] = Data.GetSeries(Data.HoursByContract);
        }

        private void SetForm()
        {
            chrtUren.Enabled = grpTotalen.Enabled = grpOverzicht.Enabled = Data.IsConnected && !Data.DbEmpty;
            grpKlokken.Enabled = Data.IsConnected;
            btnClockIn.Enabled = !Data.IsLoggedIn();
            btnClockOut.Enabled = !btnClockIn.Enabled;

            var reg = Data.Last();
            if (reg == null) return;
            SetBtnGenerate();
            lblOnline.Text = reg.CheckOut == null ? string.Format("Aanwezig sinds {0}    ({1})", 
                    reg.CheckIn.ToShortTimeString(), 
                    Registratie.TotalDuration(Data.GetRegsForDay(reg.CheckIn)))
                : string.Format("Laatst uitgeklokt op {0} om {1}", 
                    ((DateTime)reg.CheckOut).ToShortDateString(), 
                    ((DateTime)reg.CheckOut).ToShortTimeString());
            lblUrenWeek.Text = Registratie.TotalDuration(Data.GetRegsForWeek(DateTime.Now)) + "/" + Contract.Uren;
            lblUrenTotaal.Text = Registratie.TotalDuration(Data.All());
            lblUrenDiff.Text = Registratie.Difference(Data.All());
            lblUrenDiff.ForeColor = lblUrenDiff.Text.StartsWith("-") ? Color.Red : Color.Green;
            chrtUren.Series[0] = Data.GetSeries(Data.WorkedHours);
        }

        private void SetBtnGenerate()
        {
            btnGenerate.Enabled = Export.CanGenerate(dtOverzicht.Value);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            sfdOverview.FileName = string.Format("Overzicht Jeroen Aarts {0}", dtOverzicht.Value.ToString("MMMM yyyy"));
            sfdOverview.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (sfdOverview.ShowDialog() != DialogResult.OK) return;
            try
            {
                File.WriteAllText(sfdOverview.FileName, Export.GenerateOverview(dtOverzicht.Value));
                var result = MessageBox.Show(string.Format("Het overzicht is succesvol weggescreven naar {0}. Wilt u het bestand openen?"
                    , sfdOverview.FileName),
                    "Overzicht geëxporteerd", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Process.Start(sfdOverview.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Kan het bestand niet wegschrijven: {0}",ex.Message), "Er ging iets mis..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenForm(Form form)
        {
            form.Show();
            form.FormClosing += (s, ea) => SetForm();
        }

        private Point? _prevPosition;
        private readonly ToolTip _tooltip = new ToolTip();

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (_prevPosition.HasValue && pos == _prevPosition.Value)
                return;
            _tooltip.RemoveAll();
            _prevPosition = pos;
            var results = chrtUren.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);
            foreach (var result in results)
            {
                if (result.ChartElementType != ChartElementType.DataPoint) 
                    continue;
                var prop = result.Object as DataPoint;
                if (prop == null) 
                    continue;
                var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                if (Math.Abs(pos.X - pointXPixel) < 2 && Math.Abs(pos.Y - pointYPixel) < 2)
                    _tooltip.Show(string.Format("{0}; {1} uur", DateTime.FromOADate(prop.XValue).ToShortDateString(), prop.YValues[0])
                        , chrtUren, pos.X, pos.Y - 15);
            }
        }
    }
}
