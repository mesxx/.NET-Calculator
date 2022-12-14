using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            float Sum = float.Parse(input1.Text) + float.Parse(input2.Text);
            result.Text= Sum.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            float Min = float.Parse(input1.Text) - float.Parse(input2.Text);
            result.Text = Min.ToString();
        }

        private void times_Click(object sender, EventArgs e)
        {
            float Times = float.Parse(input1.Text) * float.Parse(input2.Text);
            result.Text = Times.ToString();
        }

        private void divided_Click(object sender, EventArgs e)
        {
            float Divided = float.Parse(input1.Text) / float.Parse(input2.Text);
            result.Text = Divided.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input1.Text= string.Empty;
            input2.Text= string.Empty;
            result.Text= string.Empty;
        }
    }
}
