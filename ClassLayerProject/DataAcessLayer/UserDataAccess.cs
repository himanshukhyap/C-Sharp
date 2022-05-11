using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
namespace DataAcessLayer
{
    public class UserDataAccess
    {
        public List<DataModel.UserProfile> UsersGetAll()
        {
            //ProjDbContext dbContext = new ProjDbContext();
            var dbContext = new DBConnection();
            return dbContext.UserProfiles.ToList(); 
        }
        public UserProfile UsersGetById(int UserId)
        {
            //ProjDbContext dbContext = new ProjDbContext();
            var dbContext = new DBConnection();
            return dbContext.UserProfiles.FirstOrDefault(x => x.UserId == UserId);
        }
        public UserProfile UsersGetByUserName(string UserName)
        {
            //ProjDbContext dbContext = new ProjDbContext();
            var dbContext = new DBConnection();
            return dbContext.UserProfiles.FirstOrDefault(x => x.Username == UserName);
        }
        public List<UserProfile> UserGetData(int UserId)
        {
            //ProjDbContext dbContext = new ProjDbContext();
            var dbContext = new DBConnection();
            return dbContext.UserProfiles.Where(x => x.UserId == UserId).ToList();
        }
        public List<UserProfile> UserGetData(string Username)
        {
            //ProjDbContext dbContext = new ProjDbContext();
            var dbContext = new DBConnection();
            return dbContext.UserProfiles.Where(x => x.Username == Username).ToList();
        }
       
        public void UserUpdate(UserProfile oUserProfile)
        {
            //ProjDbContext dbContext = new ProjDbContext();
            var dbContext = new DBConnection();
            dbContext.Entry(oUserProfile).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
    }
}
