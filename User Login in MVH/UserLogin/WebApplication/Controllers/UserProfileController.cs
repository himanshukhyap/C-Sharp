using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication.Model;
using WebApplication.Services;
using static WebApplication.Controllers.HomeController;

namespace WebApplication.Controllers
{
    public class UserProfileController : ApiController
    {
    
      
        //public UserProfile GetAllUser(int id)
        //{
        //    var DbConnection = new DbConnection();
        //    return DbConnection.UserProfiles.FirstOrDefault(x=>x.UserId == id);
        //}

        public List<UserProfile> Alluser()
        {
               var UserProfileService = new UserProfileService();
                return   UserProfileService.getAllUser();

        }


   

    }
}