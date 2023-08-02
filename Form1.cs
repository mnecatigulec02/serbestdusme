using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serbestdusme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1hesapla_Click(object sender, EventArgs e)
        {
            int m, g, h;
            string sonuc;
            g = 10;
            m = int.Parse(textBox2kutle.Text);
            h = int.Parse(textBox1yukseklik.Text);
            for (; h > 0; h--)
            {
                sonuc = (m * g * h).ToString();
                listBox1.Items.Add(sonuc);
            }

            string elemansayisi =listBox1.Items.Count.ToString();
            MessageBox.Show(elemansayisi);
        }
    }
}
