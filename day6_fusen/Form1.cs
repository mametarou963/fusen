using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day6_fusen
{
    public partial class Form1 : Form
    {
        private int mouseX;
        private int mouseY;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { 
                this.mouseX = e.X;
                this.mouseY = e.Y;
            }
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.BackColor = colorDialog1.Color;
        }
    }
}
