using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UrenRegistratie.Layers;
using UrenRegistratie.Models;
// ReSharper disable LocalizableElement

namespace UrenRegistratie.Forms
{
    public sealed partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Data.Initialise();
            ucWeek.SetFormOnMain = SetForm;
            SetForm();
            if (IsTesting()) Text += " TEST";

            timer1.Tick += (s, e) => SetForm();
            FormClosing += (s, e) => Data.CloseConnection();
            btnClockIn.Click += (s, e) => OpenFormLoc();
            btnClockOut.Click += (s, e) => { if (Data.CheckOut()) SetForm(); };
            lblOnline.Click += (s, e) => OpenForm(new FormEditTime());
            dtOverzicht.ValueChanged += (s, e) => SetBtnGenerate();            
            chrtUren.Series[1] = GraphLayer.GetSeries(GraphLayer.HoursByContract);
            tpChart.Controls.Add(chrtUren);
            chrtUren.Location = new Point(0, 0);
            tpUren.Controls.Add(ucWeek);
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
            ucWeek.Init();
            lblOnline.Text = StringLayer.GetLblOnlineString(reg);
            lblUrenWeek.Text = Registratie.TotalDuration(Data.GetRegsForWeek(DateTime.Now)) + "/" + Contract.Uren;
            lblUrenTotaal.Text = Registratie.TotalDuration(Data.All());
            lblUrenDiff.Text = Registratie.Difference(Data.All());
            lblUrenDiff.ForeColor = lblUrenDiff.Text.StartsWith("-") ? Color.Red : Color.Green;
            chrtUren.Series[0] = GraphLayer.GetSeries(GraphLayer.WorkedHours);
        }

        private void SetBtnGenerate()
        {
            btnGenerate.Enabled = Export.CanGenerate(dtOverzicht.Value);
        }

        private static bool IsTesting()
        {
            return Data.ConnectionString.Contains("Test");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            sfdOverview.FileName = $"Overzicht Jeroen Aarts {dtOverzicht.Value.ToString("MMMM yyyy")}";
            if (IsTesting()) sfdOverview.FileName += " TEST";
            sfdOverview.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (sfdOverview.ShowDialog() != DialogResult.OK) return;
            try
            {
                File.WriteAllText(sfdOverview.FileName, Export.GenerateOverview(dtOverzicht.Value.Date));
                var result = MessageBox.Show(
                    $"Het overzicht is succesvol weggescreven naar {sfdOverview.FileName}. Wilt u het bestand openen?",
                    "Overzicht geëxporteerd", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Process.Start(sfdOverview.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kan het bestand niet wegschrijven: {ex.Message}", "Er ging iets mis..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenFormLoc()
        {
            using (var form = new FormLoc())
            {
                if (form.ShowDialog() != DialogResult.OK) return;
                if (Data.CheckIn(form.Loc, form.Transport, form.Distance))
                    SetForm();
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
                if (prop == null || chrtUren.Series[1].Points.Contains(prop)) 
                    continue;
                var pointXPixel = result.ChartArea.AxisX.ValueToPixelPosition(prop.XValue);
                var pointYPixel = result.ChartArea.AxisY.ValueToPixelPosition(prop.YValues[0]);

                if (Math.Abs(pos.X - pointXPixel) < 2 && Math.Abs(pos.Y - pointYPixel) < 2)
                    _tooltip.Show(StringLayer.GetToolTip(prop), chrtUren, pos.X, pos.Y - 15);
            }
        }
    }
}
