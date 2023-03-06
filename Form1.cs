using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NovelAcademy;

namespace NovelAcademy
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public double grpay
        {
            get { return Convert.ToDouble(textBox4.Text); }
            set { textBox4.Text = Convert.ToString(value); }
        }

        public double inctax
        {
            get { return Convert.ToDouble(textBox7.Text); }
            set { textBox7.Text = Convert.ToString(value); }
        }

        public double neypay
        {
            get { return Convert.ToDouble(textBox5.Text); }
            set { textBox5.Text = Convert.ToString(value); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = Convert.ToString(Employees.incomeTax());
            textBox5.Text = Convert.ToString(Employees.neyPay());
        }

        public void createnewrow()
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("Employee Name", typeof(string));
            DataColumn dc2 = new DataColumn("Employee Number", typeof(string));
            DataColumn dc3 = new DataColumn("Payment Date", typeof(string));
            DataColumn dc4 = new DataColumn("Job Title", typeof(string));
            DataColumn dc5 = new DataColumn("Departments", typeof(string));
            DataColumn dc6 = new DataColumn("Gross Pay", typeof(string));
            DataColumn dc7 = new DataColumn("Income Tax", typeof(string));
            DataColumn dc8 = new DataColumn("Net Pay", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Columns.Add(dc6);
            dt.Columns.Add(dc7);
            dt.Columns.Add(dc8);
            dt.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, comboBox1.SelectedItem.ToString(), textBox4.Text, textBox7.Text, textBox5.Text);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createnewrow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
    }

   
}
