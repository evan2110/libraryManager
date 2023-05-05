using LibraryManagerWeb.BusinessObject;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerWeb.DataAccess
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private static readonly object instanceLock = new object();
        public static AccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AccountDAO();
                    }
                    return instance;
                }
            }
        }

        public Account GetAccountByEmailAndPass(Account account)
        {
            Account acc = null;
            try
            {
                using var context = new DatabaseTestProjectContext();
                acc = context.Accounts.SingleOrDefault(c => c.Email == account.Email && 
                                                            c.Password == account.Password);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return acc;
        }

        
    }
}
