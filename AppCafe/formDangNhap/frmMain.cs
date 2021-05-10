using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formDangNhap
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void LoadChildFrom(Form f)
        {
            foreach(Form fr in this.MdiChildren)
            {
                fr.Hide();
            }
            f.MdiParent = this;
            f.ControlBox = false;
            f.ShowIcon = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
            f.Dock = DockStyle.Fill;
        }
        private bool checkFormChildExist(String FormName)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.Name == FormName)
                {
                    LoadChildFrom(f);
                    return true;
                }
            }
            return false;
        }



        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkFormChildExist("frmInformationPersonal"))
            {
                lblDiaChi inf = new lblDiaChi();
                LoadChildFrom(inf);
            }
        }

        private void quảnLýTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!checkFormChildExist("frmAccounts"))
            {
                frmAccounts Accounts = new frmAccounts();
                LoadChildFrom(Accounts);
            }
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!checkFormChildExist("frmProducts"))
            {
                frmProducts Products = new frmProducts();
                LoadChildFrom(Products);
            }
        }

        private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkFormChildExist("frmAddFood"))
            {
                frmAddFood addfood = new frmAddFood();
                LoadChildFrom(addfood);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            LoadChildFrom(login);
            đăngXuấtToolStripMenuItem.Visible = false;
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            LoadChildFrom(login);
            đăngXuấtToolStripMenuItem.Visible = false;dd
        }
    }
}
