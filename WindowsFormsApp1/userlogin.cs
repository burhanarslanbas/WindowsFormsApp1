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
            kontrol();
        }
        public void kontrol()
        {
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select * from Users");
            cmd.Connection = sqlConnection1;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["username"].ToString() == txtuser.Text)
                {
                    if (dr["password"].ToString() == txtpass.Text)
                    {
                        MessageBox.Show("Bilgileriniz sistemde kayıtlıdır", "Giriş Başarılı");
                    }
                }
                // username = (string)dr["username"].ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre'yi Kontrol Ediniz!");
            }
            sqlConnection1.Close();
        }
    }
}
  