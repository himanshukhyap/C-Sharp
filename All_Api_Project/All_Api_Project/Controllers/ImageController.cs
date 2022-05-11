using All_Api_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.IO;
using System.Web.Mvc;

namespace All_Api_Project.Controllers
{
    public class ImageController : ApiController
    {
        // GET: Image
        [System.Web.Http.HttpGet]
        public List<Img_tbl> GetImage()
        {
            var db = new ImgDataConnection();
            return db.Img_tbl.ToList();
        }
        [System.Web.Http.HttpPost]
              public void PostImage()
        {
            string foldercreate = HttpContext.Current.Server.MapPath("~/Assest/");
            if (!Directory.Exists(foldercreate))
            {
                Directory.CreateDirectory(foldercreate);
            }

            if (HttpContext.Current.Request.Files.AllKeys.Any())
            {

                var fileupload = HttpContext.Current.Request.Files["FileName"];
                if (fileupload != null)

                {
                    var saveImages = Path.Combine(HttpContext.Current.Request.MapPath("/Assest/"), fileupload.FileName);

                    fileupload.SaveAs(saveImages);
                    var formData = HttpContext.Current.Request.Form;
                    var Db_Path = Path.Combine(("/Assest/"), fileupload.FileName);
                    var db = new ImgDataConnection();
                    var data = new Img_tbl();


                    data.Path = Db_Path.ToString();
                    data.Title = fileupload.FileName;
                    data.Date_Created = DateTime.Now;
                    data.Date_Modifield = null;
                    data.Width = Convert.ToDouble(formData["width"]);
                    data.Height = Convert.ToDouble(formData["Height"]);
                    data.Format = fileupload.ContentType;


                    db.Entry(data).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
            }
        }

            [System.Web.Http.HttpPut]

            public void UpdateImage(int id)
            {
               

                if (HttpContext.Current.Request.Files.AllKeys.Any())
                {

                    var fileupload = HttpContext.Current.Request.Files["FileName"];
                    if (fileupload != null)

                    {
                        var saveImages = Path.Combine(HttpContext.Current.Request.MapPath("/Assest/"), fileupload.FileName);

                        fileupload.SaveAs(saveImages);
                        var formData = HttpContext.Current.Request.Form;
                        var Db_Path = Path.Combine(("/Assest/"), fileupload.FileName);
                        var db = new ImgDataConnection();
                        var data = db.Img_tbl.FirstOrDefault(x=> x.ImgId == id);
              


                        data.Path = Db_Path.ToString();
                        data.Title = fileupload.FileName;
                        data.Date_Modifield = DateTime.Now;
                       // data.Date_Created = data.Date_Created;
                        data.Width = Convert.ToDouble(formData["width"]);
                        data.Height = Convert.ToDouble(formData["Height"]);
                    data.Format = fileupload.ContentType;
                       


                        db.Entry(data).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
        }
}