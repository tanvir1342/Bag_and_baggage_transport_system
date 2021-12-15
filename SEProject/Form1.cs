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
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(panel3.Width == 0)
            {
                panel3.Width = 249;
            }
            else
            {
                panel3.Width = 0;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Form formBackground = new Form();
            //using (Login f = new Login())
            {
                Login f = new Login();


                f.Show();
                this.Hide();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //using (signup ll = new signup())
            {
                signup ll = new signup();

                ll.Show();
                this.Hide();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
