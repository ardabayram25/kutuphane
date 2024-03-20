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
namespace yemeksepeti_1
{
    public partial class giriş_yap : Form
    {
        public giriş_yap()
        {
            InitializeComponent();
        }
        OleDbConnection bağlanti = new OleDbConnection("Provider=Microsoft.Jet.OLeDB.4.0;Data Source=arabalar.mdb;");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM kulanici";
            OleDbCommand komut = new OleDbCommand(sql, bağlanti);
            bağlanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            oku.Read();
            if (oku.GetValue(1).ToString() == textBox1.Text && oku.GetValue(2).ToString() == textBox2.Text)
            {
                anasayfa form2 = new anasayfa();
                form2.Show();
            }
            else
            {
                MessageBox.Show("kulanici_adi vea parola yanlış vea üye olun ");
            }
            bağlanti.Close();
        }
    }
}
