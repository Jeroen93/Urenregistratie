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
                var vervoer = textOfSelected(grpVervoer);
                double dist = Convert.ToDouble(tbKm.Text.Replace('.',','));
                if (Data.CheckIn(location, vervoer, dist)) this.Close();
            };
            radioThuis.CheckedChanged += (s, e) => grpVervoer.Enabled = !radioThuis.Checked;
            radioOV.CheckedChanged += (s, e) => tbKm.Enabled = !radioOV.Checked;
        }

        private string textOfSelected(GroupBox box)
        {
            return box.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
        }
    }
}
