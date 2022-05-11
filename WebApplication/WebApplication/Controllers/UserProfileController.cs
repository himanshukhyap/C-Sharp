using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;
namespace WebApplication.Controllers
{
    public class UserProfileController : ApiController
    {
        public List<UserProfile> GetUser()
        {
            var DbConnection = new DBConnection();
            return DbConnection.UserProfiles.ToList();


        }
        public HttpResponseMessage GetUserbyId(int id)
        {
            var DbConnection = new DBConnection();
            var userdata = DbConnection.UserProfiles.FirstOrDefault(x => x.UserId == id);
            if (userdata != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, userdata);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not Found User Data by given id = " + id);

            }

        }
        public UserProfile GetUserbyName(string userName)
        {
            var DbConnection = new DBConnection();
            return DbConnection.UserProfiles.FirstOrDefault(x => x.Username == userName);

        }
        public void Put(int id, [FromBody] UserProfile oProfile)
        {
            var DbConnection = new DBConnection();
            var currentuser = DbConnection.UserProfiles.Where(x => x.UserId == id).FirstOrDefault();
            currentuser.FirstName = oProfile.FirstName;
            currentuser.LastName = oProfile.LastName;
            currentuser.Username = oProfile.Username;
            currentuser.Password = oProfile.Password;

            DbConnection.Entry(currentuser).State = System.Data.Entity.EntityState.Modified;
            DbConnection.SaveChanges();

        }
        public HttpResponseMessage Delete(int id)
        {
          try
            {
                var DbConnection = new DBConnection();
                var deleteuser = DbConnection.UserProfiles.Where(x => x.UserId == id).FirstOrDefault();
                if (deleteuser == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User Not found");
                }
                else
                {
                    DbConnection.Entry(deleteuser).State = System.Data.Entity.EntityState.Deleted;
                    DbConnection.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Successful");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);  

            }


        }
        public HttpResponseMessage Post([FromBody] UserProfile oProfile)
        {
            try
            {
                var DbConnection = new DBConnection();
                //  var newuser = new UserProfile();
                //newuser.FirstName = oProfile.FirstName;
                //newuser.LastName = oProfile.LastName;
                //newuser.Username = oProfile.Username;
                //newuser.Password = oProfile.Password;   

                DbConnection.Entry(oProfile).State = System.Data.Entity.EntityState.Added;
                DbConnection.SaveChanges();
                var message = Request.CreateResponse(HttpStatusCode.OK, oProfile);
                message.Headers.Location = new Uri(Request.RequestUri + oProfile.UserId.ToString());
                return message; 
            }
            catch (Exception ex)
            {
            return    Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);     
            }

        }

    }
}
