using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Calculator
{
    public partial class Display : Form
    {
        public int input = 0;
        public double output = 0;
        public Display()
        {
            InitializeComponent();
        }

        private void read_input()
        {
            if(int.TryParse(textBox.Text,out input))
            {
                error.Text = "";
            }
            else
            {
                error.Text = "整数を入力してください";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            read_input();
            output += input;
            result.Text = output.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            read_input();
            output -= input;
            result.Text = output.ToString();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            read_input();
            output *= input;
            result.Text = output.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (input != 0)
            {
                read_input();
                output /= input;
                result.Text = output.ToString();
            }
            else
            {
                error.Text = "Infinity";
            }
        }
    }
}
