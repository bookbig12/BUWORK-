using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private SqlConnection connection;
        private DataSet dataSt;

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void ThaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Project.Properties.Resources.thai1;
            label11.Text = "ชุดไทย";
            label12.Text = "ชุดที่ทำจาก ผ้าฝ้าย ผ้าทอ ฝ้าย ผ้าใยประดิษฐ์\n" +
                "ใส่ในวันงานต่างๆหรือใช้ในการแสดง";
            label13.Text = "600";

            /*pictureBox1.Image = Properties.Resources.thai3;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer ti = new Timer();
            ti.Interval = 100;
            ti.Tick += new EventHandler(changeimage);
            ti.Start();*/
        }

        /*private void changeimage(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            List<Bitmap> p1 = new List<Bitmap>();
            p1.Add(Properties.Resources.thai1);
            p1.Add(Properties.Resources.thai2);
            p1.Add(Properties.Resources.thai3);
            int index = DateTime.Now.Second % p1.Count;
            pictureBox1.Image = p1[index];
        }*/

        private void SuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Project.Properties.Resources.Suit1;
            label11.Text = "ชุดสูท";
            label12.Text = "ชุดใส่ในการพีธีต่างๆ หรืองานสำคัญ\n" +
                "ไม่ว่าจะเป็นงานแต่งงาน งานประชุมเป็นต้น";
            label13.Text = "700";

            /*pictureBox1.Image = Properties.Resources.Suit2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Timer ti = new Timer();
            ti.Interval = 100;
            ti.Tick += new EventHandler(changeimage2);
            ti.Start();
            pictureBox1.Image = null;*/
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int price = (int)numericUpDown1.Value * Convert.ToInt32(label13.Text);
            label18.Text = Convert.ToString(price);

            string Id = "R" + textBox1.Text;
            string Name = textBox2.Text;
            string Suname = textBox3.Text;
            string Phone = textBox4.Text;
            string Address = textBox5.Text;
            string Size = textBox6.Text;
            string Bill = label18.Text;
            string Datein = textBox7.Text;
            string Dateout = textBox8.Text;
            string Amount = Convert.ToString(numericUpDown1.Value);

            string sql = "INSERT INTO Data1 (Id,Name,Suname,Phone,Address,Size,Bill,Amount,Datein,Dateout)VALUES(@Id,@Name,@Suname,@Phone,@Address,@Size,@Bill,@Amount,@Datein,@Dateout)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("Id", Id);
            command.Parameters.AddWithValue("Name", Name);
            command.Parameters.AddWithValue("Suname", Suname);
            command.Parameters.AddWithValue("Phone", Phone);
            command.Parameters.AddWithValue("Address", Address);
            command.Parameters.AddWithValue("Size", Size);
            command.Parameters.AddWithValue("Bill", Bill);
            command.Parameters.AddWithValue("Amount", Amount);
            command.Parameters.AddWithValue("Datein", Datein);
            command.Parameters.AddWithValue("Dateout", Dateout);
            command.ExecuteNonQuery();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            connection = new SqlConnection(conStr);
            connection.Open();
        }

        /*private void changeimage2(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            List<Bitmap> p2 = new List<Bitmap>();
            p2.Add(Properties.Resources.Suit1);
            p2.Add(Properties.Resources.Suit2);
            int index = DateTime.Now.Second % p2.Count;
            pictureBox1.Image = p2[index];
        }*/
    }
}
