using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class AccountsDAO
    {
        public static bool checkTK(string username)
        {
            string query = "select count(*) from ACCOUNTS where TenDangNhap = @username";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@username", username);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }
        public static bool layMK(string username, string password)
        {
            string query = "select Matkhau from ACCOUNTS where TenDangNhap = @username";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@username", username);
            return DataProvider.ExecuteSelectQuery(query, param).Rows[0][0].ToString() == password;
        }
        public static DataTable loadProduct()
        {
            string query = "select * from FOOD";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        public static DataTable loadAccounts()
        {
            string query = "select * from ACCOUNTS";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        public static bool add(AccountDTO dto)
        {
            string query = "insert into ACCOUNTS(TenDangNhap,TenHienThi,MatKhau,GioiTinh,DiaChi,SDT,Loai) values (@TenDangNhap,@TenHienThi,@MatKhau,@GioiTinh,@DiaChi,@SDT,@Loai)";
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@TenDangNhap", dto.TenDangNhap);
            param[1] = new SqlParameter("@TenHienThi", dto.TenHienThi);
            param[2] = new SqlParameter("@MatKhau", dto.MatKhau);
            param[3] = new SqlParameter("@GioiTinh", dto.GioiTinh);
            param[4] = new SqlParameter("@DiaChi", dto.DiaChi);
            param[5] = new SqlParameter("@SDT", dto.SDT);
            param[6] = new SqlParameter("@Loai", dto.Loai);
            return DataProvider.ExecuteNonQuery(query, param)== 1;
        }
    }
}