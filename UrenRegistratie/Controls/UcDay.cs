using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UrenRegistratie.Models;

namespace UrenRegistratie.Controls
{
    public partial class UcDay : UserControl
    {
        public UcDay()
        {
            InitializeComponent();
        }

        public void SetRegistrations(List<Registratie> regs, DateTime date)
        {
            groupBox1.BackColor = date.Equals(DateTime.Today) ? Color.CadetBlue : DefaultBackColor;
            lblDate.Text = date.ToString("ddd d-M");
            lblIn.Visible = lblOut.Visible = regs.Count != 0;
            if (regs.Count == 0)
            {
                lblTotaal.Text = @"Niet Gewerkt";
            }
            else
            {
                lblIn.Text = $"In: {regs[0].CheckIn.ToShortTimeString()}";
                lblOut.Text = $"Uit: {(regs.Last().CheckOut ?? DateTime.Now).ToShortTimeString()}";
                lblTotaal.Text = $"Totaal: {Registratie.TotalDuration(regs)}";
            }
        }
    }
}
