using Microsoft.VisualBasic.Devices;
using System;
using System.Reflection.Metadata;
using System.Windows.Forms;
using System.Data;
using System.Xml.Serialization;

namespace projekt_gridform_lab3

{
    public partial class Form1 : Form
    {
        public Form2 form2;
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

        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            string csvContent = "Imie,Nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {

                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            try
            {
                File.WriteAllText(filePath, csvContent);
                MessageBox.Show("Plik zapisano pomyœlnie.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ b³¹d podczas zapisywania pliku: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)//zapis do csv
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki(*.*)|*.*";
            saveFileDialog.Title = "wybierz lokalizacje";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != " ")
            {
                ExportToCSV(dataGridView1, saveFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik do wczytania";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != " ")
            {
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }

        }
        private void LoadCSVToDataGridView(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            string[] lines = File.ReadAllLines(filePath);
            DataTable dataTable = new DataTable();
            string[] naglowki = lines[0].Split(",");
            foreach (string naglowek in naglowki)
            {
                dataTable.Columns.Add(naglowek);
            }

            for (int i = 0; i < naglowki.Length; i++)
            {
                string[] values = lines[i].Split('.');
                dataTable.Rows.Add(values);
            }

            dataGridView1.DataSource = dataTable;

        }
        private void button4_Click(object sender, EventArgs e)

        {
            form2 = new Form2(this);
            form2.Show();

            // dataGridView1.Rows.Add(new object[] { "data1"});
        }
        public void SerializeToXML(string filename, Osoba osoba1)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Osoba));
            using (TextWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, osoba1);
            }
            Console.WriteLine("obiekt zosta³ zserializowany do pliku XML");
        }

        public static Osoba DeserializeFromXML(string filename, Osoba osoba1)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Osoba));
            using (TextReader reader = new StreamReader(filename))
            {
                osoba1 = (Osoba)serializer.Deserialize(reader);
                Console.WriteLine("obiekt zosta³ odczytany");
                return osoba1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFIle = new SaveFileDialog();
            saveFIle.Filter = "pliki (*.xml)|*.xml|Wszystkie pliki(*.*)|*.*";
            saveFIle.Title = "wybierz lokalizacje";
            saveFIle.ShowDialog();
            if (saveFIle.FileName != " ")
            {
                SerializeToXML(saveFIle.FileName, form2.osoba1);

            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFIle = new OpenFileDialog();
            openFIle.Filter = "pliki (*.xml)|*.xml|Wszystkie pliki(*.*)|*.*";
            openFIle.Title = "wybierz plik";
            openFIle.ShowDialog();
            if (openFIle.FileName != " ")
            {
             //   DeserializeFromXML(sa)
            }
        }
    }
}