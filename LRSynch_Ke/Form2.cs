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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            password_db.PasswordChar = '*';
            password_db.MaxLength = 10;
            panel3.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Show();
        }

        private void pOSConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            panel3.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(panel2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(panel1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(panel3);
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
    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }
    }
}
