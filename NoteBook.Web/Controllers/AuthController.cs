﻿using NoteBook.Domain.Abstract;
using NoteBook.Domain.Concrete;
using NoteBook.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace NoteBook.Web.Controllers
{
    public class AuthController : ApiController
    {

        private IRepository mRepository;
        /*public AuthController(IRepository _projectRepository)
        {
            mRepository = _projectRepository;
        }*/
        public AuthController()
        {
            mRepository = new EFRepository();
        }
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
            User user =
                mRepository.Users
                .Select(u => u)
                .Where(u => (u.login == _data.login))
                .SingleOrDefault();
            if (user != null)
            {
                //Session["dhfjg"] = 1;
                HttpContext.Current.Session["user"] = user;
                return new { signed = HttpContext.Current.Session["user"] };
            }
            else {

                return new { signed = "no_user" };
            }
            
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