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
using FastFoodDemo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FastFoodDemo
{
    public partial class login : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        koneksi konn = new koneksi();
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from tb_user Where namauser='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                this.Hide();
                conn.Close();
                FormMenuUtama frmUtama = new FormMenuUtama();
                frmUtama.Show();

            }
            else
            {
                MessageBox.Show("Sandi dan Password Salah");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
