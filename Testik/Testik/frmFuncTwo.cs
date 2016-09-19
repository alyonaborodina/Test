using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testik
{
    public partial class frmFuncTwo : Form
    {
        public frmFuncTwo()
        {
            InitializeComponent();
        }

        private int DoFunctionTwo(int a, int b)
        {
            return a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(DoFunctionTwo(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text)));
        }
    }
}
