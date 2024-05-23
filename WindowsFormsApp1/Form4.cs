using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 curform = new Form4();
            Form2 form = new Form2();
            form.Show();
            curform.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 curform = new Form4();
            Form3 form = new Form3();
            form.Show();
            curform.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 My_Form = new Form1();
            My_Form.Show();
            this.Close();
        }
    }
}
