using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using UrenRegistratie.Forms;
using UrenRegistratie.Models;

namespace UrenRegistratie.Controls
{
    public partial class UcDay : UserControl
    {
        private List<Registratie> _registraties;
        private DateTime _date;
        public event SetFormDelegate SetFormOnMain;

        public UcDay()
        {
            InitializeComponent();
        }

        private void BtnEditClick(object sender, EventArgs eventArgs)
        {
            if (_registraties.Count == 0) return;
            var form = new FormModifyReg(_date);
            form.Show();
            form.FormClosed += (s, e) =>
            {
                SetFormOnMain?.Invoke();
            };
        }

        public void SetRegistrations(List<Registratie> regs, DateTime date)
        {
            _registraties = regs;
            _date = date;
            groupBox1.BackColor = date.Equals(DateTime.Today) ? Color.CadetBlue : DefaultBackColor;
            lblDate.Text = date.ToString("ddd d-M");
            btnEdit.Image = Image.FromStream(GetImageStream(regs.Count > 0 ? "Pencil.ico" : "add.ico"));
            lblIn.Visible = lblOut.Visible = regs.Count != 0;
            if (regs.Count == 0)
            {
                lblTotaal.Text = @"Niet Gewerkt";
            }
            else
            {
                lblIn.Text = $"In: {regs[0].CheckIn.ToShortTimeString()}";
                lblOut.Text = $"Uit: {(regs.Last().CheckOut ?? DateTime.Now).ToShortTimeString()}";
                lblOut.Font = new Font(lblOut.Font, regs.Last().CheckOut.HasValue ? FontStyle.Regular : FontStyle.Bold);
                lblTotaal.Text = $"Totaal: {Registratie.TotalDuration(regs)}";
            }
        }

        private static Stream GetImageStream(string name)
        {
            var type = typeof(UcDay);
            return type.Assembly.GetManifestResourceStream("UrenRegistratie.Assets." + name);
        }
    }
}
