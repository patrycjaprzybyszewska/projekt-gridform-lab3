using Microsoft.VisualBasic.Devices;
using System;
using System.Windows.Forms;
namespace projekt_gridform_lab3

{
    public partial class Form1 : Form
    {
        public DataGridView dataGridView1 = new DataGridView();
        public Form1()
        {
            InitializeComponent();

            dataGridView1 = new DataGridView();
            dataGridView1.Size = new Size(900, 600);
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Imie", "Imie");
            dataGridView1.Columns.Add("Nazwisko", "Nazwisko");
            dataGridView1.Columns.Add("Wiek", "Wiek");
            dataGridView1.Columns.Add("Stanowskio", "Stanowsiko");
            
            Controls.Add(dataGridView1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                dataGridView1.Rows.Remove(selectedRow);
            }
        }

        private void button4_Click(object sender, EventArgs e)

        {
            Form2 form2 = new Form2(this);
            form2.Show();

           // dataGridView1.Rows.Add(new object[] { "data1"});
        }
    }
}