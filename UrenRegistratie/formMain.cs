using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            Data.Initialise();
            setForm();
            Text += Data.ConnectionString.Contains("Test") ? " TEST" : "";

            timer1.Tick += (s, e) => setForm();
            FormClosing += (s, e) => Data.CloseConnection();
            btnClockIn.Click += (s, e) => OpenForm(new formLoc());
            btnClockOut.Click += (s, e) => { if (Data.CheckOut()) setForm(); };
            lblOnline.Click += (s, e) => OpenForm(new formEditTime());
            dtOverzicht.ValueChanged += (s, e) => btnGenerate.Enabled = Export.CanGenerate(dtOverzicht.Value);
        }

        private void setForm()
        {
            grpKlokken.Enabled = grpTotalen.Enabled = grpOverzicht.Enabled = Data.IsConnected;
            btnClockIn.Enabled = !Data.IsLoggedIn();
            btnClockOut.Enabled = !btnClockIn.Enabled;

            var reg = Data.Last();
            if (reg == null) return;
            lblOnline.Text = reg.checkOut == null ? "Aanwezig sinds " + reg.checkIn.ToShortTimeString() 
                + "    (" + Registratie.TotalDuration(Data.GetRegsForDay(reg.checkIn)) + ")"
                : "Laatst uitklokt op " + ((DateTime)reg.checkOut).ToShortDateString() + " om " 
                + ((DateTime)reg.checkOut).ToShortTimeString();
            lblUrenWeek.Text = Registratie.TotalDuration(Data.GetRegsForWeek()) + "/" + Contract.Uren;
            lblUrenTotaal.Text = Registratie.TotalDuration(Data.All());
            lblUrenDiff.Text = Registratie.Difference(Data.All());
            lblUrenDiff.ForeColor = lblUrenDiff.Text.StartsWith("-") ? Color.Red : Color.Green;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            sfdOverview.FileName = "Overzicht Jeroen Aarts " + dtOverzicht.Value.ToString("MMMM yyyy");
            sfdOverview.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (sfdOverview.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sfdOverview.FileName, Export.GenerateOverview(dtOverzicht.Value));
                    var result = MessageBox.Show("Het overzicht is succesvol weggescreven naar " + sfdOverview.FileName
                        + ". Wilt u het bestand openen?",
                        "Overzicht geëxporteerd", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                        Process.Start(sfdOverview.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Er ging iets mis..", "Kan het bestand niet wegschrijven: " + ex.Message,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void OpenForm(Form form)
        {
            form.Show();
            form.FormClosing += (s, ea) => setForm();
        }
    }
}
