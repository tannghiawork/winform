using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS

{
    public class AccountsBUS
    {
        public static bool checkTK(string tk , string mk)
        {
          if(AccountsDAO.checkTK(tk))
          {
              if(AccountsDAO.layMK(tk,mk))
                  return true;
              return false;
          }
             return false;
        }

        public static DataTable loadProduct()
        {
            return AccountsDAO.loadProduct();
        }

        public static DataTable loadAccounts()
        {
            return AccountsDAO.loadAccounts();
        }

        public static bool addAccount(AccountDTO dto)
        {
            return AccountsDAO.add(dto);
        }
    }
}
