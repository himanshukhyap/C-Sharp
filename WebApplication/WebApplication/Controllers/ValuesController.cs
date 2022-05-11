using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication.Models;
namespace WebApplication.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public string [] userdata()
        {

            //new string[] { "value1", "value2" };
            string[] arr = { "HImanshu", "Kashyap" };
            return arr;
        }

        // GET api/values/5
        public string Get(string userName)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return value;
        }
        public string Post([FromBody] string key, string value)
        {
            return key;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
