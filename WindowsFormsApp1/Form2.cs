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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.бригада_поездовTableAdapter.Fill(this._13пршербдDataSet.Бригада_поездов);
            бригада_поездовDataGridView.Visible = true;
            расписание_движения_поездовDataGridView.Visible = false;
            работникиDataGridView.Visible = false;
            поездаDataGridView.Visible = false;
            ведомость_продажи_билетовDataGridView.Visible = false;
        }

        private void бригада_поездовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бригада_поездовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._13пршербдDataSet);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            бригада_поездовDataGridView.Visible = false;
            расписание_движения_поездовDataGridView.Visible = false;
            работникиDataGridView.Visible = false;
            поездаDataGridView.Visible = false;
            ведомость_продажи_билетовDataGridView.Visible = false;
        }

        private void бригада_поездовDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ведомость_продажи_билетовTableAdapter.Fill(this._13пршербдDataSet.Ведомость_продажи_билетов);
            ведомость_продажи_билетовDataGridView.Visible = true;
            бригада_поездовDataGridView.Visible = false;
            расписание_движения_поездовDataGridView.Visible = false;
            работникиDataGridView.Visible = false;
            поездаDataGridView.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.поездаTableAdapter.Fill(this._13пршербдDataSet.Поезда);
            поездаDataGridView.Visible = true;
            бригада_поездовDataGridView.Visible = false;
            расписание_движения_поездовDataGridView.Visible = false;
            работникиDataGridView.Visible = false;
            ведомость_продажи_билетовDataGridView.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.работникиTableAdapter.Fill(this._13пршербдDataSet.Работники);
            работникиDataGridView.Visible = true;
            бригада_поездовDataGridView.Visible = false;
            расписание_движения_поездовDataGridView.Visible = false;
            поездаDataGridView.Visible = false;
            ведомость_продажи_билетовDataGridView.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.расписание_движения_поездовTableAdapter.Fill(this._13пршербдDataSet.Расписание_движения_поездов);
            расписание_движения_поездовDataGridView.Visible = true;
            бригада_поездовDataGridView.Visible = false;
            работникиDataGridView.Visible = false;
            поездаDataGridView.Visible = false;
            ведомость_продажи_билетовDataGridView.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 My_Form = new Form1();
            My_Form.Show();
            this.Close();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            бригада_поездовTableAdapter1.Update(_13пршербдDataSet);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ведомость_продажи_билетовTableAdapter1.Update(_13пршербдDataSet);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            поездаTableAdapter1.Update(_13пршербдDataSet);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            работникиTableAdapter1.Update(_13пршербдDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            расписание_движения_поездовTableAdapter1.Update(_13пршербдDataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (расписание_движения_поездовDataGridView.Visible)
            {
                расписание_движения_поездовBindingSource.Filter = textBox2.Text;
                расписание_движения_поездовBindingSource.Sort = textBox1.Text;
            }
            else if (бригада_поездовDataGridView.Visible)
            {
                бригада_поездовBindingSource.Filter = textBox2.Text;
                бригада_поездовBindingSource.Sort = textBox1.Text;
            }
            else if (работникиDataGridView.Visible)
            {
                работникиBindingSource.Filter = textBox2.Text;
                работникиBindingSource.Sort = textBox1.Text;
            }
            else if (поездаDataGridView.Visible)
            {
                поездаBindingSource.Filter = textBox2.Text;
                поездаBindingSource.Sort = textBox1.Text;
            }
            else if (расписание_движения_поездовDataGridView.Visible)
            {
                расписание_движения_поездовBindingSource.Filter = textBox2.Text;
                расписание_движения_поездовBindingSource.Sort = textBox1.Text;
            }
        }
    }
}
