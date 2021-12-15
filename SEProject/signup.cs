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


    public partial class signup : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["Se_project"].ConnectionString;

        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into Crequest (B_id,resoan) values(@B_id,@resoan)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("B_id", textBox1.Text);
                cmd.Parameters.AddWithValue("resoan", textBox1.Text);
                

                int a = cmd.ExecuteNonQuery();


                if (a > 0)
                {
                    Login u = new Login();
                    this.Hide();
                    u.Show();
                }
                else
                {
                    MessageBox.Show("Ghawra information vul dissis");
                }
            }
            else
            {
                MessageBox.Show("Ghawra age textbox fill up to kor");
            }











        }
    }
}
