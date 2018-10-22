using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.DataAccess.Location
{
  public class LocationManager
  {

    private Vehicle_ManagementEntities Context;
    private LocationManager locationManager;
    ResultObj<bool> result;

    public LocationManager()
    {
    //  this.locationManager = new LocationManager();
      this.Context = new Vehicle_ManagementEntities();
    }
    public LocationManager(Vehicle_ManagementEntities entities)
    {
      this.Context = entities;
    }

    public ResultObj<bool> LogTrip(LocationParameters location)
    {
      result = new ResultObj<bool>() { ResultType= ActionCode.location, isSuccessful = false, Error = string.Empty };

      try
      {
        VihecleTrackingLog log = new VihecleTrackingLog();

        log.Latitud = location.Latitude.ToString();
        log.Longitude = location.Longtude.ToString();
        log.LogDate = DateTime.Now;   
        log.TripLogStatus = location.status;

        log.TripId = Convert.ToInt16(location.tripId);
    

        this.Context.VihecleTrackingLogs.Add(log);

        this.Context.SaveChanges();

        result.Data = true;
        result.isSuccessful = true;
        return result;

      }
      catch(Exception ex) {

        result.isSuccessful = false;
        result.Data = false;
        result.Error = ex.Message;
        return result;

      }
     



    }

  }
}
