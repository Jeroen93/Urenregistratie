using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Data.Initialise();
            SetForm();
            Text += Data.ConnectionString.Contains("Test") ? " TEST" : "";

            timer1.Tick += (s, e) => SetForm();
            FormClosing += (s, e) => Data.CloseConnection();
            btnClockIn.Click += (s, e) => OpenForm(new FormLoc());
            btnClockOut.Click += (s, e) => { if (Data.CheckOut()) SetForm(); };
            lblOnline.Click += (s, e) => OpenForm(new FormEditTime());
            dtOverzicht.ValueChanged += (s, e) => btnGenerate.Enabled = Export.CanGenerate(dtOverzicht.Value);            
            chrtUren.Series[1] = Data.GetSeries(Data.HoursByContract);
        }

        private void SetForm()
        {
            grpKlokken.Enabled = grpTotalen.Enabled = grpOverzicht.Enabled = Data.IsConnected;
            btnClockIn.Enabled = !Data.IsLoggedIn();
            btnClockOut.Enabled = !btnClockIn.Enabled;

            var reg = Data.Last();
            if (reg == null) return;
            lblOnline.Text = reg.CheckOut == null ? "Aanwezig sinds " + reg.CheckIn.ToShortTimeString() 
                + "    (" + Registratie.TotalDuration(Data.GetRegsForDay(reg.CheckIn)) + ")"
                : "Laatst uitklokt op " + ((DateTime)reg.CheckOut).ToShortDateString() + " om " 
                + ((DateTime)reg.CheckOut).ToShortTimeString();
            lblUrenWeek.Text = Registratie.TotalDuration(Data.GetRegsForWeek(DateTime.Now)) + @"/" + Contract.Uren;
            lblUrenTotaal.Text = Registratie.TotalDuration(Data.All());
            lblUrenDiff.Text = Registratie.Difference(Data.All());
            lblUrenDiff.ForeColor = lblUrenDiff.Text.StartsWith("-") ? Color.Red : Color.Green;
            chrtUren.Series[0] = Data.GetSeries(Data.WorkedHours);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            sfdOverview.FileName = "Overzicht Jeroen Aarts " + dtOverzicht.Value.ToString("MMMM yyyy");
            sfdOverview.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (sfdOverview.ShowDialog() != DialogResult.OK) return;
            try
            {
                File.WriteAllText(sfdOverview.FileName, Export.GenerateOverview(dtOverzicht.Value));
                var result = MessageBox.Show(@"Het overzicht is succesvol weggescreven naar " + sfdOverview.FileName
                                             + @". Wilt u het bestand openen?",
                    @"Overzicht geëxporteerd", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Process.Start(sfdOverview.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Kan het bestand niet wegschrijven: " + ex.Message, @"Er ging iets mis..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenForm(Form form)
        {
            form.Show();
            form.FormClosing += (s, ea) => SetForm();
        }
    }
}
