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

namespace WindowsFormsApp1
{
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }
        public string username, password;
        private void userlogin_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(sqlConnection1.State.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtpass.Text != "") && (txtuser.Text != ""))
            {
                kontrol();
            }
            else
            {
                txtpass.Text = "";
                txtuser.Text = "";
                MessageBox.Show("Kullanıcı Adı ve Şifre boş bırakılamaz!");
            }
        }
        public void formgecisapp()
        {
            app frm = new app();
            this.Hide();
            frm.Show();
        }

        
        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(this, new EventArgs());

            }
        }

        public void kontrol()
        {
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select username,password from Users",sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if ((dr["username"].ToString() == txtuser.Text) && (dr["password"].ToString() == txtpass.Text))
                {
                    formgecisapp();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifreyi tekrar kontrol ediniz.");
                }
                // username = (string)dr["username"].ToString();
            }
            sqlConnection1.Close();
        }
    }
}