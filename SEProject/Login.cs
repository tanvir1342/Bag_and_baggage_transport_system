using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Configuration;
//using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;

namespace SEProject
{
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Se_project"].ConnectionString;
       // string cs = ConfigurationManager.ConnectionStrings["Se_project"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }
        public static int number;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")

            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from client where id = @id and pass = @pass";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("id", textBox1.Text);
                cmd.Parameters.AddWithValue("pass", textBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    number = Convert.ToInt32(dt.Rows[0]["id"].ToString());
                    client a = new client();
                    this.Hide();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Ghawra tor password or id vul,abar de");
                }
            }
            else
            {
                MessageBox.Show("Ghawra tor password nai,niye ay");
            }


        }
    }
}
