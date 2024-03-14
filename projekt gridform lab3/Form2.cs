using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_gridform_lab3
{
 
    public partial class Form2 : Form
    {
        public int id = 0;
        private Form1 form2;
        public Form2(Form1 form2)
        {
            InitializeComponent();
            this.form2 = form2;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            form2.dataGridView1.Rows.Add(new object[] {id, textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text});

            id++;
            form2.dataGridView1.Show();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string nazwisko = textBox3.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string age = textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
