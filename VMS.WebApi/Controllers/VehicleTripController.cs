using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VMS.DataAccess.VehicleTrip;

namespace VMS.WebApi.Controllers
{
  [RoutePrefix("api/vehicletrip")]
  public class VehicleTripController : ApiController
    {
    VehicleTripManager vehicleTripManager;
    public VehicleTripController()
    {
      vehicleTripManager = new VehicleTripManager();

    }
    [HttpGet, Route("trips/{id}")]
    public IHttpActionResult Save(int id)
    {

      var result =vehicleTripManager.GetVehicleTripByTripId(id);



      return Ok(result);
    }
  }
}
