using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRSynch_Ke
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 supportform = new Form6();
            supportform.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Close();
        }

        private void schedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 posmapping = new Form4();
            posmapping.Show();
        }
    }
}
