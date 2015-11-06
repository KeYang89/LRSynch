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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pos_config_Paint(object sender, PaintEventArgs e)
        {
     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 generalconfig = new Form2();
            generalconfig.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(panel1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(panel2);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(panel3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 scheduler = new Form5();
            scheduler.Show();
        }

        private void mappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 posmapping = new Form4();
            posmapping.Show();
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 supportform = new Form6();
            supportform.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
