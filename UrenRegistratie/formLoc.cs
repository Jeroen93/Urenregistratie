using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrenRegistratie
{
    public partial class formLoc : Form
    {
        public formLoc()
        {
            InitializeComponent();            
            btnOk.Click += (s, e) => {
                var location = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                if (Data.CheckIn(location)) this.Close();
            };
        }
    }
}
