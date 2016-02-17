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

        public FormModifyReg(DateTime date)
        {
            InitializeComponent();
            btnOk.Click += (s, e) => Close();
            _registraties = Data.GetRegsForDay(date);
            _date = date;
            lbRegs.SelectedIndexChanged += (s, e) => SetLabels();
            FillBox();
        }

        private void SetLabels()
        {
            var reg = _registraties[lbRegs.SelectedIndex];
            groupBox1.Text = _date.ToShortDateString();
            lblCheckIn.Text = reg.CheckIn.ToShortTimeString();
            lblCheckOut.Text = (reg.CheckOut ?? DateTime.Now).ToShortTimeString();
            lblLocation.Text = reg.Location;
            lblTransport.Text = reg.ModeOfTransport == "" ? "n.v.t" : reg.ModeOfTransport;
        }

        private void FillBox()
        {
            lbRegs.Items.Clear();
            _registraties.ForEach(r => lbRegs.Items.Add(r.ToString()));
            lbRegs.SelectedIndex = 0;
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
    }
}
