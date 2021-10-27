using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void RentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.T_shirt1;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer ti = new Timer();
            ti.Interval = 400;
            ti.Tick += new EventHandler(changeimage);
            ti.Start();

            pictureBox1.Image = Properties.Resources.T_shirt1;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer ti2 = new Timer();
            ti2.Interval = 400;
            ti2.Tick += new EventHandler(changeimage2);
            ti2.Start();
        }

        private void changeimage2(object sender, EventArgs e)
        {
            List<Bitmap> p2 = new List<Bitmap>();
            p2.Add(Properties.Resources.Dress1);
            p2.Add(Properties.Resources.pajama3);
            p2.Add(Properties.Resources.T_shirt1);
            p2.Add(Properties.Resources.Dress3);
            int index = DateTime.Now.Second % p2.Count;
            pictureBox1.Image = p2[index];
        }

        private void changeimage(object sender, EventArgs e)
        {
            List<Bitmap> p1 = new List<Bitmap>();
            p1.Add(Properties.Resources.pajama1);
            p1.Add(Properties.Resources.pajama2);
            p1.Add(Properties.Resources.T_shirt2);
            p1.Add(Properties.Resources.T_shirt3);
            int index = DateTime.Now.Second % p1.Count;
            pictureBox2.Image = p1[index];
        }

        private void EditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void DataSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
