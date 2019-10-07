using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paladyn
{
    public partial class frmMain : Form
    {
        God god;
        public frmMain()
        {
            InitializeComponent();
            god = new God();
        }

        private void bAddThread_Click(object sender, EventArgs e)
        {
            Textgen textgen = new Textgen();
            god.Genesis(textgen);
            lbThread.DataSource = god.ListTextgens();
        }
    }
}
