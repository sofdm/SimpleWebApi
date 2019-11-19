using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class ValuesController : ApiController
    {

        static List<string> StringsList = new List<string> ()
        { 
            "Luffy", "Sanji", "Zoro" 
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return StringsList;
        }

        // GET api/values/5
        public string Get(int id)
        {

            return StringsList[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            StringsList.Add(value);
            
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            StringsList[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {

            StringsList.RemoveAt(id);
        }
    }
}
