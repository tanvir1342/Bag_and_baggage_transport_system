using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SEProject
{
    public partial class client : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Se_project"].ConnectionString;

        public client()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel5.Width == 0)
            {
                panel5.Width = 814;
                panel6.Width = 0;
                panel7.Width = 0;
                panel2.BorderStyle = BorderStyle.Fixed3D;
                panel3.BorderStyle = BorderStyle.None;
                panel4.BorderStyle = BorderStyle.None;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel6.Width == 0)
            {
                panel6.Width = 814;
                panel5.Width = 0;
                panel7.Width = 0;
                panel3.BorderStyle = BorderStyle.Fixed3D;
                panel2.BorderStyle = BorderStyle.None;
                panel4.BorderStyle = BorderStyle.None;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel7.Width == 0)
            {
                panel7.Width = 814;
                panel6.Width = 0;
                panel5.Width = 0;
                panel4.BorderStyle = BorderStyle.Fixed3D;
                panel2.BorderStyle = BorderStyle.None;
                panel3.BorderStyle = BorderStyle.None;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && comboBox1.Text !="")
            {
                if(comboBox1.Text == "Samll vechile")
                  {
                    
                    SqlConnection con = new SqlConnection(cs);
                    string query = "insert into post_small(id,fcity,tcity,time_depreture,type_of_vechile) values(@id,@fcity,@tcity,@time_depreture,@type_of_vechile)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("fcity", textBox1.Text);
                    cmd.Parameters.AddWithValue("id", Login.number);
                    cmd.Parameters.AddWithValue("tcity", textBox2.Text);
                    cmd.Parameters.AddWithValue("time_depreture", textBox4.Text);
                    cmd.Parameters.AddWithValue("type_of_vechile", comboBox1.Text);

                    int a = cmd.ExecuteNonQuery();


                    if (a > 0)
                    {
                        MessageBox.Show("Posted");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox4.Clear();
                        comboBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Post failed");
                    }
                con.Close();
                }
                else if (comboBox1.Text == "1 Ton")
                {

                    SqlConnection con = new SqlConnection(cs);
                    string query = "insert into post_1ton (id,fcity,tcity,time_depreture,type_of_vechile) values(@id,@fcity,@tcity,@time_depreture,@type_of_vechile)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("fcity", textBox1.Text);
                    cmd.Parameters.AddWithValue("id", Login.number);
                    cmd.Parameters.AddWithValue("tcity", textBox2.Text);
                    cmd.Parameters.AddWithValue("time_depreture", textBox4.Text);
                    cmd.Parameters.AddWithValue("type_of_vechile", comboBox1.Text);

                    int a = cmd.ExecuteNonQuery();


                    if (a > 0)
                    {
                        MessageBox.Show("Posted");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox4.Clear();
                        comboBox1.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Post failed");
                    }
                }
                else
                {
                    MessageBox.Show("wrong Vechile type");
                }

            }
            else
            {
                MessageBox.Show("Ghawra age textbox fill up to kor");
            }
        }

        private void client_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select *FROM post_small where id = '"+Login.number+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 14);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
            this.dataGridView1.Columns[0].Width = 100; 
            this.dataGridView1.Columns[1].Width = 250;
            this.dataGridView1.Columns[4].Width = 200;
            //this.dataGridView1.Rows.GetRowsHeight();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select *FROM post_1ton where id= '" + Login.number + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into post_1ton (id,fcity,tcity,time_depreture,type_of_vechile) values(@id,@fcity,@tcity,@time_depreture,@type_of_vechile)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("fcity", textBox1.Text);
                cmd.Parameters.AddWithValue("id",Login.number);

                cmd.Parameters.AddWithValue("tcity", textBox2.Text);
                cmd.Parameters.AddWithValue("time_depreture", textBox4.Text);
                cmd.Parameters.AddWithValue("type_of_vechile", comboBox1.Text);

                int a = cmd.ExecuteNonQuery();


                if (a > 0)
                {
                    MessageBox.Show("Posted");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox4.Clear();
                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Post failed");
                }
            }
            else
            {
                MessageBox.Show("Fill all info");
            }

        }
    }
}
