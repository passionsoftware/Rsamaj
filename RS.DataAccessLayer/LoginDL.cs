using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.DataModel;
using RS.DataAccessLayer.entitydata;


namespace RS.DataAccessLayer
{
    public class LoginDL
    {

        public int InsertLogin(LoginModel obj)
        {
            int result = 0;

            return result;
        }

        public int UpdateLogin(LoginModel obj)
        {
            int result = 0;

            return result;
        }

        public int DeleteLogin(int Id)
        {
            int result = 0;

            return result;
        }

        public List<LoginModel> GetAllLogin()
        {
            List<LoginModel> result = new List<LoginModel>();

            return result;
        }

        public LoginModel GetLoginId(int Id)
        {
            LoginModel result = new LoginModel();


            return result;
        }

        /// <summary>
        /// Checking the login details
        /// </summary>
        /// <param name="lm"></param>
        /// <returns></returns>
        public LoginModel CheckLoginDetail(LoginModel lm)
        {
            LoginModel result = new LoginModel();

            using (RSEntities obj = new RSEntities())
            {
                result = (from odata in obj.RS_RathoreDetails
                          where odata.UserName == lm.UserName && odata.Password == lm.Password
                          select new LoginModel
                          {
                              RathoreDetailId = odata.RathoreDetailId,
                              Name = odata.Name,
                              UserName = odata.UserName,
                              LastLogin = odata.LastLogin,
                              LoginCount = odata.LoginCount,
                              Role = odata.Role
                          }).FirstOrDefault();
            }

            return result;
        }



        /// <summary>
        /// Update the login detail information
        /// </summary>
        /// <param name="lm"></param>
        /// <returns></returns>
        public int UpdateLoginInfoDetail(LoginModel lm)
        {
            int result = 0;

            using (RSEntities obj = new RSEntities())
            {
                var oData = obj.RS_RathoreDetails.First(i => i.RathoreDetailId == lm.RathoreDetailId);

                oData.LastLogin = DateTime.Now;
                oData.LoginCount = oData.LoginCount == null ? 1 : oData.LoginCount + 1;
                oData.ModifiedOn = DateTime.Now;
                oData.ModifiedBy = lm.RathoreDetailId;
                result =  obj.SaveChanges();
            }

            return result;
        }
    }
}
