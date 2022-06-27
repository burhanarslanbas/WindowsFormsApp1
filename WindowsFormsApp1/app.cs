using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        private void btnuseradd_Click(object sender, EventArgs e)
        {
            adduser frm = new adduser();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void app_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc==DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                userlogin frm = new userlogin();
                this.Hide();
                frm.Show();
            }
        }
    }
}
