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

namespace formDangNhap
{
    public partial class frmLoginAplication : Form
    {
        public frmLoginAplication()
        {
            InitializeComponent();

        }
        void clearform()
        {
            cboAccount.SelectedIndex=0;
            txtPassword.Clear();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Accounts = cboAccount.Text;
            string pass = txtPassword.Text;
            //tạo kết nối
            SqlConnection connect = new SqlConnection("Data Source=ADMIN-GON\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
            //mở kết nối
            connect.Open();
            //tạo câu truy vấn 
            string SQL = string.Format("SELECT COUNT(*) AS SoLuong FROM TaiKhoan WHERE TenDangNhap='{0}' AND MatKhau='{1}'",Accounts,pass);
            SqlCommand cmd = new SqlCommand(SQL,connect);
            //thực thi truy vấn
            SqlDataAdapter Adapter =new SqlDataAdapter();
            Adapter.SelectCommand =cmd;
            DataTable table = new DataTable();
            Adapter.Fill(table);
            int i = Convert.ToInt32(table.Rows[0]["SoLuong"]);
            //đóng kết nối
            connect.Close();

            if (i > 0)
            {
                MessageBox.Show("Đăng nhập thành công!","Thông báo");
                //login vào form chính 
                frmapplicationSystem App = new frmapplicationSystem();
                this.Hide();
                App.ShowDialog();
                this.Close();

            }
            else
                MessageBox.Show("Không thành công!");
            //xóa thông tin login
            clearform();

           

        }

        private void LoginAplication_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(dr==DialogResult.OK)
            {
                e.Cancel = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLoginAplication_Load(object sender, EventArgs e)
        {
            string pass = txtPassword.Text;
            //tạo kết nối
            SqlConnection connect = new SqlConnection("Data Source=ADMIN-GON\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True");
            //mở kết nối
            connect.Open();
            //tạo câu truy vấn 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT TenDangNhap FROM TaiKhoan";
            cmd.Connection = connect;
            //thực thi truy vấn
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            Adapter.Fill(table);

            cboAccount.DataSource = table;
            cboAccount.DisplayMember = "TenDangNhap";
            //đóng kết nối
            connect.Close();

        }
    }
}
