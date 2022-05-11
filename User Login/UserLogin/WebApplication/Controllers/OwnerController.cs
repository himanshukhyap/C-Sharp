using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication.Model;

namespace WebApplication.Controllers
{
    public class OwnerController : ApiController
    {
        
        public List<OwnerTbl> GetAllOwner()
        {
            var DbConnection = new OwnerEmpConnection();
            return DbConnection.OwnerTbls.ToList();
        }
        
        public OwnerTbl OwnerbyId(int id)
        {

            var DbConnection = new OwnerEmpConnection();
            return DbConnection.OwnerTbls.FirstOrDefault(x => x.OwnerId == id);

        }
        public OwnerTbl OwnerByUsername(string Username)
        {

            var DbConnection = new OwnerEmpConnection();
            return DbConnection.OwnerTbls.FirstOrDefault(x => x.UserName == Username);

        }

        public OwnerTbl NewData([FromBody] OwnerTbl oOwnerTbl)
        {

            var DbConnection = new OwnerEmpConnection();
            var newuser = new OwnerTbl();
            newuser.Fname = oOwnerTbl.Fname;
            newuser.Lname = oOwnerTbl.Lname;
            newuser.UserName = oOwnerTbl.UserName;
            newuser.Password = oOwnerTbl.Password;

            DbConnection.Entry(newuser).State = System.Data.Entity.EntityState.Added;
            DbConnection.SaveChanges();
            return oOwnerTbl;
        }
        public bool Authentication(LoginModel LoginModel)
        {
            var DbConnection = new OwnerEmpConnection();

            var username = OwnerByUsername(LoginModel.Username).UserName;  

            if (username == null)
            {
                return false;

            }
            else
            {
                var password = DbConnection.OwnerTbls.FirstOrDefault(x=>x.UserName == username).Password;    
                if (password == LoginModel.Password)
                {
                    return true;
                }
                return false;
            }



        }

        public class LoginModel
        {

            public string Username { get; set; }
            public string Password { get; set; }

        }

    }
}