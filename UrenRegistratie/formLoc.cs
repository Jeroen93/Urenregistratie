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
                var location = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
                if (Data.CheckIn(location)) this.Close();
            };
        }
    }
}
