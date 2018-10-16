using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace POCMobile.Model
{
  public partial class VehicleMaintenance
  {
    public long VehicleMaintenanceId { get; set; }
    public long VehicleId { get; set; }
    public int ServiceTypeId { get; set; }
    public int OdoMeter { get; set; }
    public System.DateTime ServiceDate { get; set; }
    public string Comments { get; set; }

    public virtual ServiceType ServiceType { get; set; }
    public virtual Vehicle Vehicle { get; set; }
  }
}
