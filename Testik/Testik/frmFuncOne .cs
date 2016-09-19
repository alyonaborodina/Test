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
    public partial class frmFuncOne : Form
    {
        public frmFuncOne()
        {
            InitializeComponent();
        }



        private int DoFunctionOne(int a, int b)
        {
            return a * b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(DoFunctionOne(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox1.Text)));
        }

        private void frmFuncOne_Load(object sender, EventArgs e)
        {

        }
    }


}
