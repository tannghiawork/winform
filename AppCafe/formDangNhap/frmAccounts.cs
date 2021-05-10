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
using DTO;


namespace formDangNhap
{
    public partial class frmAccounts : Form
    {
        public frmAccounts()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AccountsBUS.loadAccounts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccountDTO dto =new AccountDTO();
            dto.TenDangNhap= txtTDN.Text;
            dto.TenHienThi = txtTHT.Text;
            dto.MatKhau = txtMK.Text;
            dto.GioiTinh= txtGT.Text;
            dto.DiaChi= txtDC.Text;
            dto.SDT = txtSDT.Text;
            dto.Loai = Convert.ToInt32(txtL.Text);
            if (AccountsBUS.addAccount(dto))
            {
                MessageBox.Show("Them Thanh Cong");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = AccountsBUS.loadAccounts();
            }
            else
            {
                MessageBox.Show("Them That Bai");
            }
        }
    }
}
