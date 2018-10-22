using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VMS.DataAccess;


namespace VMS.WebApi.Controllers
{
  [RoutePrefix("api/trip")]
  public class TripController : ApiController
  {
    TripManager tripManager;

    public TripController()
    {
      this.tripManager = new TripManager();
    }

    [HttpGet, Route("get/{reference}")]
    public IHttpActionResult Get(int reference)
    {
      var result =tripManager.TripByRefExist(reference);

      return Ok(result);
    }
  }


}
