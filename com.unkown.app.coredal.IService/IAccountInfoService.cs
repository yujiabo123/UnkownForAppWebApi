using System;
using System.Collections.Generic;
using System.Text;
using com.unkown.app.Models;

namespace com.unkown.app.coredal.IService
{
    public interface IAccountInfoService : IBaseService
    {
        AccountInfo GetWithAccountId(int accountId);
        AccountInfo GetWithAccount(string account);
        bool UpdateWithAccountId(int accountId);
    }
}
