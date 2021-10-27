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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private SqlConnection connection;
        private DataSet dataSt;
        private void selectData()
        {
            string sql = "SELECT  * FROM  Data1";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dataSt = new DataSet();
            adapter.Fill(dataSt, "Data1");

            

            comboBox1.Items.Clear();
            comboBox1.Text = "เลือกไอดี";
            for (int i = 0; i < dataSt.Tables["Data1"].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataSt.Tables["Data1"].Rows[i]["id"].ToString());
            }

        }

        /*private void Data1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.data1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }*/

        private void Form4_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

            connection = new SqlConnection(conStr);
            connection.Open();
            selectData();

            dataGridView1.DataSource = dataSt.Tables["Data1"];

        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sql2 = @"UPDATE Data1 SET Name = @Name, Suname = @Suname, Phone = @Phone , Address = @Address , Datein = @Datein, Dateout = @Dateout,  Size = @Size, Bill = @Bill, Amount = @Amount WHERE Id = @Id";

            SqlCommand command = new SqlCommand(sql2, connection);

            command.Parameters.Clear();
            command.Parameters.AddWithValue("Id",comboBox1.SelectedItem.ToString());
            command.Parameters.AddWithValue("Name", TextBox2.Text);
            command.Parameters.AddWithValue("Suname", TextBox3.Text);
            command.Parameters.AddWithValue("Phone", TextBox4.Text);
            command.Parameters.AddWithValue("Address", TextBox5.Text);
            command.Parameters.AddWithValue("Datein", TextBox6.Text);
            command.Parameters.AddWithValue("Dateout", TextBox7.Text);
            command.Parameters.AddWithValue("Size", TextBox8.Text);
            command.Parameters.AddWithValue("Bill", TextBox9.Text);
            command.Parameters.AddWithValue("Amount", TextBox10.Text);

            command.ExecuteNonQuery();

            selectData();
            dataGridView1.DataSource = dataSt.Tables["Data1"];

            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string id = comboBox1.SelectedItem.ToString();

            string sql = "DELETE FROM Data1 WHERE (Id = @Id)";
            SqlCommand command = new SqlCommand(sql, connection);


            command.Parameters.Clear();
            command.Parameters.AddWithValue("Id", id);

            command.ExecuteNonQuery();


            selectData();

            dataGridView1.DataSource = dataSt.Tables["Data1"];
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string sql2 = "SELECT * FROM Data1 WHERE Id = @oldFN";

            SqlCommand command = new SqlCommand(sql2, connection);

            command.Parameters.Clear();
            command.Parameters.AddWithValue("oldFN", comboBox1.SelectedItem.ToString());

            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            dataSt = new DataSet();
            adapter.Fill(dataSt, "Dat");

            
            TextBox2.Text = dataSt.Tables["Dat"].Rows[0][1].ToString();
            TextBox3.Text = dataSt.Tables["Dat"].Rows[0][2].ToString();
            TextBox4.Text = dataSt.Tables["Dat"].Rows[0][3].ToString();
            TextBox5.Text = dataSt.Tables["Dat"].Rows[0][4].ToString();
            TextBox6.Text = dataSt.Tables["Dat"].Rows[0][5].ToString();
            TextBox7.Text = dataSt.Tables["Dat"].Rows[0][6].ToString();
            TextBox8.Text = dataSt.Tables["Dat"].Rows[0][7].ToString();
            TextBox9.Text = dataSt.Tables["Dat"].Rows[0][8].ToString();
            TextBox10.Text = dataSt.Tables["Dat"].Rows[0][9].ToString();

        }

    }
}
