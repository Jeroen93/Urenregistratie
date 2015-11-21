using System;
using System.Linq;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class FormLoc : Form
    {
        public FormLoc()
        {
            InitializeComponent();            
            btnOk.Click += (s, e) => {
                var location = TextOfSelected(grpLoc);
                var vervoer = radioThuis.Checked ? "" : TextOfSelected(grpVervoer);
                var dist = Convert.ToDouble(tbKm.Text.Replace('.',','));
                if (Data.CheckIn(location, vervoer, dist)) Close();
            };
            radioOV.CheckedChanged += (s, e) => { 
                tbKm.Enabled = lblKm.Enabled = !radioOV.Checked;
                if (radioOV.Enabled) tbKm.Text = @"0,0";
            };
        }

        private static string TextOfSelected(Control box)
        {
            return box.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            grpVervoer.Enabled = !radioThuis.Checked;
            tbKm.Text = !radioThuis.Checked && !radioOV.Checked ? "4,4" : "0,0";
        }
    }
}
