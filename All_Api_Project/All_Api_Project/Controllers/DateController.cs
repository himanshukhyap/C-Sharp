using All_Api_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace All_Api_Project.Controllers
{
    public class DateController : ApiController
    {
        // GET: Date
        public List<Date_tbl> GetDate()
        {
            var db = new DateConnection();
            return db.Date_tbl.ToList();
        }

        public Date_tbl PostDate([FromBody] Date_tbl ndate_Tbl)
        {
            var db = new DateConnection();
            var data = new Date_tbl();
            data.Year = ndate_Tbl.Year;
            data.Month = ndate_Tbl.Month;
            data.day = ndate_Tbl.day;
            data.OnlyDateTime = ndate_Tbl.OnlyDateTime;
            data.OnlyDate = ndate_Tbl.OnlyDate;
            data.MonthName = ndate_Tbl.MonthName;
            data.OnlyTime = ndate_Tbl.OnlyTime;


            db.Entry(data).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return ndate_Tbl;
        }
    }
}