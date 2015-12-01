using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UrenRegistratie
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
                lblIn.Text = string.Format("In: {0}", regs[0].CheckIn.ToShortTimeString());
                lblOut.Text = string.Format("Uit: {0}", (regs.Last().CheckOut ?? DateTime.Now).ToShortTimeString());
                lblTotaal.Text = string.Format("Totaal: {0}", Registratie.TotalDuration(regs));
            }
        }
    }
}
