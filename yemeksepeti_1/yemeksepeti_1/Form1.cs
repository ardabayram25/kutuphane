using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemeksepeti_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            giriş_yap form1 = new giriş_yap();
            form1.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kayıtol form3 = new kayıtol();
            form3.Show();
        }
    }
}
