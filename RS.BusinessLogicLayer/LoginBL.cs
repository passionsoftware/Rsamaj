using RS.DataAccessLayer;
using RS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BusinessLogicLayer
{
    public class LoginBL
    {
        LoginDL _loginDL;

        public LoginBL()
        {
            _loginDL = new LoginDL();
        }

        public int InsertLogin(LoginModel obj)
        {
            int result = 0;
            result = _loginDL.InsertLogin(obj);
            return result;
        }

        public int UpdateLogin(LoginModel obj)
        {
            int result = 0;
            result = _loginDL.UpdateLogin(obj);
            return result;
        }

        public int DeleteLogin(int id)
        {
            int result = 0;
            result = _loginDL.DeleteLogin(id);
            return result;
        }

        public List<LoginModel> GetAllLogin()
        {
            List<LoginModel> result = new List<LoginModel>();
            result = _loginDL.GetAllLogin();
            return result;
        }

        public LoginModel GetLoginId(int id)
        {
            LoginModel result = new LoginModel();
            result = _loginDL.GetLoginId(id);
            return result;
        }

        public LoginModel CheckLoginDetail(LoginModel obj)
        {
            LoginModel result = new LoginModel();
            result = _loginDL.CheckLoginDetail(obj);
            return result;
        }

        public int UpdateLoginInfoDetail(LoginModel obj)
        {
            int result = 0;
            result = _loginDL.UpdateLoginInfoDetail(obj);
            return result;
        }

    }
}
