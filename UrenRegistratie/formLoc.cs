using System;
using System.Linq;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class formLoc : Form
    {
        public formLoc()
        {
            InitializeComponent();            
            btnOk.Click += (s, e) => {
                var location = textOfSelected(grpLoc);
                var vervoer = radioThuis.Checked ? "" : textOfSelected(grpVervoer);
                var dist = Convert.ToDouble(tbKm.Text.Replace('.',','));
                if (Data.CheckIn(location, vervoer, dist)) this.Close();
            };
            radioCareServant.CheckedChanged += (s, e) => { if (radioCareServant.Checked && !radioOV.Checked) tbKm.Text = "4,4"; };
            radioRecornect.CheckedChanged += (s, e) => { if (radioRecornect.Checked && !radioOV.Checked) tbKm.Text = "13,1"; };
            radioThuis.CheckedChanged += (s, e) => { 
                grpVervoer.Enabled = !radioThuis.Checked;
                if (radioThuis.Enabled) tbKm.Text = "0,0";
            };
            radioOV.CheckedChanged += (s, e) => { 
                tbKm.Enabled = lblKm.Enabled = !radioOV.Checked;
                if (radioOV.Enabled) tbKm.Text = "0,0";
            };
        }

        private string textOfSelected(GroupBox box)
        {
            return box.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
        }
    }
}
