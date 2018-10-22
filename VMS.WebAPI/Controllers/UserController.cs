using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VMS.DataAccess;

namespace VMS.WebApi.Controllers
{
  [RoutePrefix("api/user")]
  public class UserController : ApiController
  {
    UserManager userManager;
    public UserController()
    {
      this.userManager = new UserManager();
    }
    public UserController(UserManager usermanager)
    {
      this.userManager = usermanager;
    }

    [HttpGet, Route("login/{usr}/{pwd}")]
    public IHttpActionResult Login(string usr, string pwd)
    {
      var result = this.userManager.ValidateUser(usr, pwd);

      return Ok(result);
    }
  }
}
