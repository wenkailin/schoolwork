using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cwCh6Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Cups(double heads)
        {
            return heads * 8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cups, ounces;
            if (Double.TryParse(textBox1.Text, out cups))
            {
                ounces = Cups(cups);
                label2.Text = ounces.ToString();
            } else
            {
                MessageBox.Show("Enter an integer.");
            }
        }
    }
}
