using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataAcessLayer;
namespace BusinessAccessLayer
{
    public class UserBusinessAccess
    {
        public bool AuthenticateUser(string UserName, string Password)
        {
            //get user 
            var oUserDB = new UserDataAccess();
            UserProfile oUserFound = oUserDB.UsersGetByUserName(UserName);
            if (oUserFound == null)
                return false;
            return oUserFound.Password == Password;
        }

        public bool AuthenticateUser(UserProfile oUserData)
        {
            //get user 
            var oUserDB = new UserDataAccess();
            UserProfile oUserFound = oUserDB.UsersGetByUserName(oUserData.Username);
            if (oUserFound == null)
                return false;
            return oUserFound.Password == oUserData.Password;
        }
        public UserProfile GetUserByUserName(string Uname)
        {
            var GetData = new UserDataAccess();
            return GetData.UsersGetByUserName(Uname);
            //GetData.UserUpdate(fname, lname, Pass, data.UserId);
        }
        public bool UpdateUser(string fname, string lname, string Uname, string Pass)
        {
            var CurrentUser = GetUserByUserName(Uname);
            if (CurrentUser == null)
                return false;
            CurrentUser.FirstName = fname;
            CurrentUser.LastName = lname;
            CurrentUser.Password = Pass;

            var oDataAccess = new UserDataAccess();
            oDataAccess.UserUpdate(CurrentUser);
            return true;
        }

    }
}
