using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using System.Data.SqlClient;
>>>>>>> Update

namespace WindowsFormsApp1
{
    public partial class adduser : Form
    {
        public adduser()
        {
            InitializeComponent();
        }

        private void adduser_Load(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void btnadd_Click(object sender, EventArgs e)
        {

        }
    }
}
=======
        public void kullanıcıekle()
        {
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("Insert into Users(username,password,perm) values('" + txtuser.Text + "','" + txtpass.Text + "','" + cmbperm.Text + "')",sqlConnection1);
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            kullanıcıekle();
        }
    }
}
>>>>>>> Update
