using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS.DataAccess.Model
{
  public class VehicleTrip
  {
    public int TripLogId { get; set; }
    public int? TripId { get; set; }

    public string Latitud { get; set; }

    public string Longitude { get; set; }

    public string TripLogStatus { get; set; }

    public DateTime? LogDate { get; set; }
  }
}
