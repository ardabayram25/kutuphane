﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace uyg_1
{
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:Kütüphane.mdb");

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            MessageBox.Show("girdiğiniz bilgiler kendimizcek kaydedilecek onaylıyormusunuz musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo);
            OleDbCommand komut = new OleDbCommand("Insert into klnc(KullaniciAdi,Sifre) values ('" + textBox1.Text + "','" + textBox2.Text + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 ko = new Form1();
            ko.Show();
            this.Hide();
        }

       
    }
}
