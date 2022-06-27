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
    public partial class adduser : Form
    {
        public adduser()
        {
            InitializeComponent();
        }
        public void kullanıcıekle()
        {
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Insert into Users(username,password,perm) values('" + txtuser.Text + "','" + txtpass.Text + "','" + cmbperm.Text + "')", sqlConnection1);
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            kullanıcıekle();
        }

        private void adduser_FormClosed(object sender, FormClosedEventArgs e)
        {
            app frm = new app();
            this.Hide();
            frm.Show();
        }
    }
}