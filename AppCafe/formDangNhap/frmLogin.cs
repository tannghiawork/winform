using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;


namespace formDangNhap
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtPass.Text;
            if(AccountsBUS.checkTK(username,password))
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
                MessageBox.Show("Dang nhap that bai");
        }
    }
}
