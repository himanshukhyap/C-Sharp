using OwnerEmployee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace OwnerEmployee.Controllers
{
    public class EmployeeController : ApiController
    {
        public List<Employeetbl> GetAllEmployee()
        {

            var DbConnection = new OwnerEmpConnection();
            return DbConnection.Employeetbls.ToList();
        }
        public Employeetbl EmpById(int id)
        {

            var DbConnection = new OwnerEmpConnection();
            return DbConnection.Employeetbls.FirstOrDefault(x => x.EmpId == id);

        }
        public bool Delete(int id)
        {

            var DbConnection = new OwnerEmpConnection();
     var    newuser=   DbConnection.Employeetbls.FirstOrDefault(x => x.EmpId == id);
            DbConnection.Entry(newuser).State = System.Data.Entity.EntityState.Deleted;
            DbConnection.SaveChanges();
            return true;

        }
        public Employeetbl NewData([FromBody] Employeetbl oEmployeetbl)
        {

            var DbConnection = new OwnerEmpConnection();
            var newuser = new Employeetbl();
            newuser.OwnerId = oEmployeetbl.OwnerId;  
            newuser.Fname = oEmployeetbl.Fname;  
            newuser.Lname = oEmployeetbl.Lname;  
            newuser.DOB = oEmployeetbl.DOB;  
         
           

            DbConnection.Entry(newuser).State = System.Data.Entity.EntityState.Added;
            DbConnection.SaveChanges();
            return oEmployeetbl;
        }
        [System.Web.Http.HttpPut]
        public Employeetbl Update([FromBody] Employeetbl oEmployeetbl)
        {

            var DbConnection = new OwnerEmpConnection();
            var data = DbConnection.Employeetbls.FirstOrDefault(x => x.EmpId == oEmployeetbl.EmpId);


            data.Fname = oEmployeetbl.Fname;
            data.Lname = oEmployeetbl.Lname;
            data.DOB = oEmployeetbl.DOB;



            DbConnection.Entry(data).State = System.Data.Entity.EntityState.Modified;
            DbConnection.SaveChanges();
            return oEmployeetbl;
        }
    }
}