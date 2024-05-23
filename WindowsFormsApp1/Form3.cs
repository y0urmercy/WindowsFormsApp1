using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Str = "";
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = textBox1.Text;
            System.Data.OleDb.OleDbDataReader myReader = oleDbCommand1.ExecuteReader();
            while (myReader.Read())
            {
                for (int i = 0; i < myReader.FieldCount; i++)
                {
                    Str += myReader[i].ToString() + "    ";
                }
                listBox1.Items.Add(Str);
            }
            myReader.Close();
            oleDbConnection1.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbConnection1.Open();
            oleDbCommand1.CommandText = textBox2.Text;
            oleDbCommand1.ExecuteNonQuery();
            MessageBox.Show("Успешно.");
            oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 My_Form = new Form1();
            My_Form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
