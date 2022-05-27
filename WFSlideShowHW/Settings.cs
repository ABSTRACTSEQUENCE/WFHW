using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSlideShowHW
{
    
    public partial class Settings : Form
    {
        public int returnable;
        public Settings()
        {
            InitializeComponent();
        }

        private void interval_Scroll(object sender, EventArgs e)
        {
            l_interval.Text = interval.Value.ToString();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            returnable = interval.Value;
            Close();
        }
    }
}
