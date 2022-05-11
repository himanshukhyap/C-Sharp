using System;
using System.Collections.Generic;
using System.Linq;

using WebApplication.Model;

using System.Web.Http;

namespace WebApplication.DAL
{
    public class UserProfileDAL
    {
        public List<UserProfile> GetAllUser()
        {
            var DbConnection = new DbConnection();
            return DbConnection.UserProfiles.ToList();
        }
        public UserProfile GetUserByUsername(string Username)
        {
            var DbConnection = new DbConnection();
            return DbConnection.UserProfiles.FirstOrDefault(m=>m.Username==Username);
        }
        public UserProfile  UserbyId(int id)
        {
   
            var DbConnection = new DbConnection();
            return DbConnection.UserProfiles.FirstOrDefault(x => x.UserId == id);

        }

        public UserProfile NewData([FromBody] UserProfile oProfile)
        {
           
                var DbConnection = new DbConnection();
                var newuser = new UserProfile();
                newuser.FirstName = oProfile.FirstName;
                newuser.LastName = oProfile.LastName;
                newuser.Username = oProfile.Username;
                newuser.Password = oProfile.Password;   

                DbConnection.Entry(newuser).State = System.Data.Entity.EntityState.Added;
                DbConnection.SaveChanges();
            return oProfile;
        }

    }
}