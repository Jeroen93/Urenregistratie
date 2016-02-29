using System;
using System.Linq;
using System.Windows.Forms;

namespace UrenRegistratie.Forms
{
    public partial class FormLoc : Form
    {
        public string Loc { get; private set; }
        public string Transport { get; private set; }
        public double Distance { get; private set; }

        public FormLoc()
        {
            InitializeComponent();
            btnOk.Click += (s, e) =>
            {
                Loc = TextOfSelected(grpLoc);
                Transport = radioThuis.Checked ? "" : TextOfSelected(grpVervoer);
                Distance = Convert.ToDouble(tbKm.Text.Replace('.', ','));
                DialogResult = DialogResult.OK;
                Close();
            };
            radioOV.CheckedChanged += (s, e) =>
            {
                tbKm.Enabled = lblKm.Enabled = !radioOV.Checked;
                if (radioOV.Enabled) tbKm.Text = @"0,0";
            };
        }

        private static string TextOfSelected(Control box)
        {
            return box.Controls.OfType<RadioButton>().First(r => r.Checked).Text;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            grpVervoer.Enabled = !radioThuis.Checked;
            tbKm.Text = !radioThuis.Checked && !radioOV.Checked ? "4,4" : "0,0";
        }
    }
}
