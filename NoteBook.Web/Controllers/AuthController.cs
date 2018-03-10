using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NoteBook.Web.Controllers
{
    public class AuthController : ApiController
    {
        // GET api/<controller>
        /*public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        public dynamic Get(RecipeInformation _data)
        {

            return new { signed = _data.login };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public dynamic Post(RecipeInformation _data)
        {
            return new { signed = _data.login };
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }

    public class RecipeInformation
    {
        public string login { get; set; }
        public string password { get; set; }
    }
}