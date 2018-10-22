using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VMS.DataAccess;
using VMS.DataAccess.Location;

namespace VMS.WebApi.Controllers
{
  [RoutePrefix("api/location")]
  public class LocationController : ApiController
    {

    LocationManager locationManager;
    public LocationController()
    {
      
      this.locationManager = new LocationManager();
    }
    public LocationController(LocationManager manager)
    {
      this.locationManager = manager;
    }

    [HttpGet, Route("save/{lat}/{lon}/{status}/{reference}")]
    public IHttpActionResult Save(string lat, string lon,string status,string reference)
    {
      LocationParameters data = new LocationParameters() { Latitude = lat, Longtude = lon, status=status,tripId= reference };
     
      JsonSerializerSettings serSettings = new JsonSerializerSettings();
      serSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

     // var data = JsonConvert.DeserializeObject<LocationParameters>(param);

      
     
      var result = this.locationManager.LogTrip(data);

      return Ok(result);
    }
  }

 
}
