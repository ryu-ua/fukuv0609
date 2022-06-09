using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("荒川　龍\n");
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            textBox1.Left += int.Parse(textBox1.Text);
            textBox2.Top += int.Parse(textBox2.Text);
           
        }
    }
}
