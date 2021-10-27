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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void TShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Project.Properties.Resources.T_shirt1;
            label3.Text = "เสื้อยืด";
            label6.Text = "เสื้อยืดเสื้อที่เหมาะกับการใส่ในวันธรรมดา\n" +
                "หรือใส่ที่ต่างๆไม่ร้อนไม่หนาวใส่ได้ทั้งชายและหญิง";
            label5.Text = "200";
        }

        private void DressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Project.Properties.Resources.Dress1;
            label3.Text = "ชุดเดรส";
            label6.Text = "ชุดสำหรับผู้หญิง\n" +
                "โดยมีลักษณะในการตัดเย็บส่วนบน (เสื้อ) และส่วนล่าง\n" +
                " (กระโปรง) ต่อกัน (รวมเป็นชิ้นเดียว)\n" +
                "เป็นที่นิยมของสาว ๆ ทุกยุคทุกสมัย และสามารถนำไปสวมใส่ \n" +
                "และใช้ได้แทบทุกโอกาส";
            label5.Text = "500";
        }

        private void PajamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Project.Properties.Resources.pajama1;
            label3.Text = "ชุดนอน";
            label6.Text = "ใส่ได้ทั้งชายแหละหญิง\n" +
                "ชุดสำหรับการใส่นอนมีผ้านุ่มสบาย\n" +
                "เหมาะแก่การใส่นอนไม่ร้อนให้ความอบอุ่มพอดี\n";
            label5.Text = "300";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int price = (int)numericUpDown1.Value * Convert.ToInt32(label5.Text);
            label19.Text = Convert.ToString(price);

            string Id = "B" + textBox1.Text;
            string Name = textBox2.Text;
            string Suname = textBox3.Text;
            string Phone = textBox4.Text;
            string Address = textBox5.Text;
            string Size = textBox6.Text;
            string Bill = label19.Text;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"; ;

            connection = new SqlConnection(conStr);
            connection.Open();

        }
    }
}
