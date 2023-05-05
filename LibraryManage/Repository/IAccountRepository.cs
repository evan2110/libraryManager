using LibraryManage.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManage.Repository
{
    public interface IAccountRepository
    {
        Account GetAccountByEmailAndPass(Account account);
    }
}
