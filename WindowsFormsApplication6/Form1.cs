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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLeDB.4.0;Data Source=arabalar.mdb;");
        OleDbCommand komut;
        OleDbDataAdapter da;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        void verilerilistele()
        {
            
            baglanti.Open();

            da = new OleDbDataAdapter("Select * From arabalar" , baglanti);
            DataTable arabalar = new DataTable();

            da.Fill(arabalar);
            dataGridView1.DataSource = arabalar;
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verilerilistele();
            giderlerlistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO arabalar (araba_marka , kilometre , yıl , hata_boya ) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox4.Text + "')";
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            verilerilistele();
        }
        void giderlerlistele()
        {
            baglanti.Open();

            da = new OleDbDataAdapter("Select * From giderler", baglanti);
            DataTable basma = new DataTable();

            da.Fill(basma);
            dataGridView2.DataSource = basma;
            baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string masraf = "INSERT INTO giderler (boya ,yemekmasrafı , yıkama , kira , yakıt  ) VALUES ('" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "' , '" + textBox8.Text + "','" + textBox9.Text + "')";
            OleDbCommand sonuç = new OleDbCommand(masraf, baglanti);

            baglanti.Open();
            sonuç.ExecuteNonQuery();
            baglanti.Close();
            giderlerlistele();
        }

        void silme()
        {
            baglanti.Open();

            da = new OleDbDataAdapter("DELETE * From giderler WHERE", baglanti);
            DataTable veli = new DataTable();

            da.Fill(veli);
            dataGridView2.DataSource = veli;

            baglanti.Close();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string masraf = "INSERT INTO giderler (boya ,yemekmasrafı , yıkama , kira , yakıt  ) ('" + textBox10.Text + "')";
            OleDbCommand velican = new OleDbCommand(masraf, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            silme();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
