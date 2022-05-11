using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication.DAL;
using WebApplication.Model;
using static WebApplication.Controllers.HomeController;

namespace WebApplication.Services
{
    public class UserProfileService
    {

        public bool Authentication(LoginModel userdata)
        {
            var UserProfileDAL = new UserProfileDAL();

            var username = UserProfileDAL.GetUserByUsername(userdata.UserName).Username;
           
            if (username == null)
            {
                return false;   

            }
            else
            {
                var password = UserProfileDAL.GetUserByUsername(userdata.UserName).Password;
                if (password == userdata.Password)
                {
                    return true;    
                }
                return false;   
            }
                  


        }
        public List<UserProfile> getAllUser()
        {
            var UserProfileDAL = new UserProfileDAL();
          return  UserProfileDAL.GetAllUser();

        }
        public UserProfile userbyusername(string username)
        {
            var UserProfileDAL = new UserProfileDAL();
            return UserProfileDAL.GetUserByUsername(username);   
        }
    }
}