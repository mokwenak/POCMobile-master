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
  public partial class ServiceType
  {
    public ServiceType()
    {
      this.VehicleMaintenances = new HashSet<VehicleMaintenance>();
    }

    public int ServiceTypeId { get; set; }
    public string ServiceTypeName { get; set; }

    public virtual ICollection<VehicleMaintenance> VehicleMaintenances { get; set; }
  }
}
