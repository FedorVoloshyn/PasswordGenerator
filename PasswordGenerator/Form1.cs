using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        PasswordGenerator generator;
        public Form1()
        {
            InitializeComponent();
            generator = new PasswordGenerator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = generator.Generete((int)numberOfSymbols.Value, GetLanguage(), checkBox1.Checked, checkBox2.Checked, checkBox3.Checked);
        }

        private void numberOfSymbols_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private int GetLanguage()
        {
            if (radioButton1.Checked)
                return 1;
            else
                return 2;
        }

        private void numberOfSymbols_ValueChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
