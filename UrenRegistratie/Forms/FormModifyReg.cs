using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UrenRegistratie.Layers;
using UrenRegistratie.Models;

namespace UrenRegistratie.Forms
{
    public partial class FormModifyReg : Form
    {
        private List<Registratie> _registraties;
        private DateTime _date;
        private readonly Addmode _add;

        public FormModifyReg(DateTime date, bool addmode)
        {
            InitializeComponent();
            _date = date;
            _add = new Addmode(_date) {IsAdding = addmode};
            btnOk.Click += (s, e) => Close();
            lblLocation.Click += (s, e) => OpenFormLoc();
            lbRegs.SelectedIndexChanged += (s, e) => SetLabels();
            if (_add.IsAdding)
            {
                EnableAddmode();
                return;
            }
            _registraties = Data.GetRegsForDay(date);
            FillBox();
        }

        private void EnableAddmode()
        {
            dtCheckIn.Value = _date.Date.AddHours(8.0);
            dtCheckOut.Value = _date.Date.AddHours(17.0);
            lblLocation.Text = @"Niet ingesteld";
            label4.Text = lblTransport.Text = "";
        }

        private void SetLabels()
        {
            var reg = _registraties[lbRegs.SelectedIndex];
            groupBox1.Text = _date.ToShortDateString();
            dtCheckIn.Value = reg.CheckIn;
            dtCheckOut.Value = reg.CheckOut ?? DateTime.Now;
            dtCheckIn.Enabled = dtCheckOut.Enabled = _add.IsAdding;
            lblLocation.Text = reg.Location;
            lblTransport.Text = reg.ModeOfTransport == "" ? "n.v.t" : reg.ModeOfTransport;
        }

        private void FillBox()
        {
            lbRegs.Items.Clear();
            _registraties.ForEach(r => lbRegs.Items.Add(r.ToString()));
            lbRegs.SelectedIndex = 0;
        }

        private void OpenFormLoc()
        {
            using (var form = new FormLoc())
            {
                if (form.ShowDialog() != DialogResult.OK) return;
                lblLocation.Text = _add.Loc = form.Loc;
                lblTransport.Text = _add.Transport = form.Transport;
                _add.Distance = form.Distance;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(@"Weet u zeker dat u deze registratie wilt verwijderen?", 
                @"Registratie verwijderen", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            try
            {
                if (!Data.Delete(_registraties[lbRegs.SelectedIndex]))
                    throw new Exception();
                _registraties = Data.GetRegsForDay(_date);
                if (_registraties.Count == 0)
                {
                    Close();
                    return;
                }
                FillBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Er ging iets mis met het verwijderen: {ex.Message}", @"Registratie verwijderen mislukt");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var reg = _add.ToRegistratie();
            if (!_add.IsValid())
            {
                MessageBox.Show(@"Vul goed in");
            }else if (Data.CheckIn(reg))
            {
                _registraties = Data.GetRegsForDay(_date);
                FillBox();
            }
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            _add.CheckIn = dtCheckIn.Value;
            _add.CheckOut = dtCheckOut.Value;
        }
    }
}
