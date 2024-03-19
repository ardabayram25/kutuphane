using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLeDB.4.0;Data Source=arabalar.mdb;");
        OleDbCommand komut;
        OleDbDataAdapter da;
        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            sataraba();
        }
        void sataraba()
        {

            baglanti.Open();

            da = new OleDbDataAdapter("Select * From satılanarbalar", baglanti);
            DataTable satılanarabalar = new DataTable();

            da.Fill(satılanarabalar);
            dataGridView1.DataSource = satılanarabalar;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO satılanarbalar (marka_model,yıl,satılma_tarihi,renk) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "')";
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            sataraba();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;

        }
    }
}
