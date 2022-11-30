using WebAPI_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity;

namespace WebAPI_V2.Controllers
{
    public class UserController : ApiController
    {
        public HttpResponseMessage Get()
        {
            List<UserContext.Users> UserList = new List<UserContext.Users>();
            using (UserContext dc = new UserContext())
            {
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, UserList);
                return response;
            }
        }
    }
}
