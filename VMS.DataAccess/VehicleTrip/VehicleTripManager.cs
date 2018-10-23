using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.DataAccess.VehicleTrip
{
  public class VehicleTripManager
  {
    private Vehicle_ManagementEntities Context;

    public VehicleTripManager()
    {
      this.Context = new Vehicle_ManagementEntities();
    }

    public ResultObj<IEnumerable<VMS.DataAccess.Model.VehicleTrip>> GetVehicleTripByTripId(int tripId)
    {
      ResultObj<IEnumerable<VMS.DataAccess.Model.VehicleTrip>> result = new ResultObj<IEnumerable<VMS.DataAccess.Model.VehicleTrip>>() { isSuccessful = false, Error = string.Empty };


      try
      {
        var data = (from s in Context.VihecleTrackingLogs
                    where s.TripId == tripId
                    orderby s.LogDate
                    select new VMS.DataAccess.Model.VehicleTrip
                    {
                       TripLogId = s.TripLogId,
                        Latitud = s.Latitud,
                         LogDate = s.LogDate,
                         Longitude = s.Longitude,
                          TripLogStatus = s.TripLogStatus,
                           TripId = s.TripId                          


                    }).ToList();
        result.Data = data;
        result.isSuccessful = true;

        return result;
      }catch(Exception ex)
      {
        result.Data = null;
        result.isSuccessful = false;
        result.Error = ex.Message;

        return result;
      }

    }
  }
}
