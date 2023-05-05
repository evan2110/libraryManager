using LibraryManage.BusinessObject;
using LibraryManage.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManage.Repository
{
    public class AccountRepository:IAccountRepository
    {

        public Account GetAccountByEmailAndPass(Account account) => AccountDAO.Instance.GetAccountByEmailAndPass(account);

    }
}
