using System;
using System.Collections.Generic;
using System.Text;

namespace com.unkown.app.coredal.IService
{
    public interface IApplicationService : IBaseService
    {
        string GetToken();
        void Login();
        void Logout();
        void GetVertifyCode();
        void GetMessage();
        void UpdateLoginPassword();

    }
}
