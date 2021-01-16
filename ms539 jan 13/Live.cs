using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ms539_jan_13
{
    public partial class Live : Form
    {
        public Live()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi!","GO", MessageBoxButtons.OK);

            if (cb_Web.CheckState == CheckState.Checked)
            {
                MessageBox.Show("web checked == checked","msg box 2", MessageBoxButtons.OK);

            }
        }
    }
}
