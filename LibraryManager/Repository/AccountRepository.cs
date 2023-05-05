using LibraryManagerWeb.DataAccess;
using LibraryManagerWeb.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerWeb.Repository
{
    public class AccountRepository:IAccountRepository
    {

        public Account GetAccountByEmailAndPass(Account account) => AccountDAO.Instance.GetAccountByEmailAndPass(account);

    }
}
