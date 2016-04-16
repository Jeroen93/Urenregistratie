using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UrenRegistratie.Layers;
using UrenRegistratie.Models;
// ReSharper disable SwitchStatementMissingSomeCases

namespace UrenRegistratie.Forms
{
    public partial class FormModifyReg : Form
    {
        private List<Registratie> _registraties;
        private Registratie _selectedReg;
        private DateTime _date;
        private Addmode _add;
        private FormMode _formMode;

        public FormModifyReg(DateTime date, bool add)
        {
            InitializeComponent();
            btnOk.Click += (s, e) => Close();
            lblLocation.Click += (s, e) => OpenFormLoc();
            lbRegs.SelectedIndexChanged += (s, e) => SetLabels();

            _date = date;
            gbRegData.Text = _date.ToShortDateString();
            _registraties = Data.GetRegsForDay(_date);
            _add = new Addmode(_date);
            SetMode(add ? FormMode.Add : FormMode.View);
            if (add) ChangeFormToMode(_formMode);
        }

        private void SetMode(FormMode mode)
        {
            if (_formMode == mode)
                return;
            _formMode = mode;
            ChangeFormToMode(mode);
        }

        private void ChangeFormToMode(FormMode mode)
        {
            dtCheckIn.Enabled = dtCheckOut.Enabled = !IsViewing();
            lblLocation.Cursor = IsViewing() ? DefaultCursor : Cursors.Hand;
            btnAdd.Text = mode == FormMode.Edit ? "Opslaan" : "Toevoegen";
            switch (mode)
            {
                case FormMode.Add:
                    dtCheckIn.Value = _date.Date.AddHours(9.0);
                    dtCheckOut.Value = _date.Date.AddHours(17.0);
                    lblLocation.Text = @"Niet ingesteld";
                    lblLocation.Font = new Font(lblTransport.Font, FontStyle.Bold);
                    lblTransportValue.Text = "";
                    btnEditDelete.Text = @"Annuleren";
                    break;
                case FormMode.Edit:
                    btnEditDelete.Text = @"Verwijderen";
                    break;
                case FormMode.View:
                    btnEditDelete.Text = @"Aanpassen";
                    FillBox();
                    break;
            }
        }

        private void AddNewReg()
        {
            string reason;
            if (!_add.IsValid(out reason))
            {
                MessageBox.Show(reason, @"Toevoegen mislukt");
            }
            else if (Data.Add(_add.ToRegistratie()))
            {
                _registraties = Data.GetRegsForDay(_date);
                _add = new Addmode(_date);
                SetMode(FormMode.View);
            }
        }

        private void DeleteReg()
        {
            var result = MessageBox.Show(@"Weet u zeker dat u deze registratie wilt verwijderen?", @"Registratie verwijderen", MessageBoxButtons.YesNo);
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
                SetMode(FormMode.View);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Er ging iets mis met het verwijderen: {ex.Message}", @"Registratie verwijderen mislukt");
            }
        }

        private void SetLabels()
        {
            _selectedReg = _registraties[lbRegs.SelectedIndex];
            dtCheckIn.Value = _selectedReg.CheckIn;
            dtCheckOut.Value = _selectedReg.CheckOut ?? DateTime.Now;
            lblLocation.Text = _selectedReg.Location;
            lblTransportValue.Text = _selectedReg.ModeOfTransport == "" ? "n.v.t" : _selectedReg.ModeOfTransport;
        }

        private void FillBox()
        {
            lbRegs.Items.Clear();
            _registraties.ForEach(r => lbRegs.Items.Add(r.ToString()));
            lbRegs.SelectedIndex = 0;
        }

        private bool IsViewing()
        {
            return _formMode == FormMode.View;
        }

        private void OpenFormLoc()
        {
            if (IsViewing())
                return;
            using (var form = new FormLoc())
            {
                if (form.ShowDialog() != DialogResult.OK) return;
                lblLocation.Text = _add.Location = form.Loc;
                lblLocation.Font = new Font(lblTransport.Font, FontStyle.Regular);
                lblTransportValue.Text = _add.ModeOfTransport = form.Transport;
                _add.Distance = form.Distance;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (_formMode)
            {
                case FormMode.View:
                    SetMode(FormMode.Edit);
                    break;
                case FormMode.Add:
                    if (_registraties.Count == 0)
                    {
                        Close();
                        return;
                    }
                    lblLocation.Font = new Font(lblTransport.Font, FontStyle.Regular);
                    SetMode(FormMode.View);
                    break;
                case FormMode.Edit:
                    DeleteReg();
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (_formMode)
            {
                case FormMode.View:
                    SetMode(FormMode.Add);
                    break;
                case FormMode.Add:
                    AddNewReg();
                    break;
                case FormMode.Edit:
                    //Save the modified reg
                    SetMode(FormMode.View);
                    break;
            }
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            _add.CheckIn = dtCheckIn.Value;
            _add.CheckOut = dtCheckOut.Value;
        }
    }

    public enum FormMode
    {
        Add,
        Edit,
        View
    }
}
