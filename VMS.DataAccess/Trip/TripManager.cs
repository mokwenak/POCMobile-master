using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.DataAccess
{
  public class TripManager
  {
    private Vehicle_ManagementEntities Context;

    public TripManager()
    {
      this.Context = new Vehicle_ManagementEntities();
    }
  

    public ResultObj<bool> TripByRefExist(int reference)
    {
      ResultObj<bool> result = new ResultObj<bool>() { ResultType= ActionCode.trip, isSuccessful = false, Error = string.Empty };

      try
      {
        result.Data = (Context.Trips.Where(o => o.TripId == reference).Count()>0);
        result.isSuccessful = true;


        return result;
      }
      catch(Exception ex)
      {
        result.Data = false;
        result.Error = ex.Message;
        return result;
      }

     
    }
  }
}
