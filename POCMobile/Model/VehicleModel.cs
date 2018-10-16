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
  public partial class VehicleModel
  {
    public VehicleModel()
    {
      this.Vehicles = new HashSet<Vehicle>();
    }

    public int VehicleModelId { get; set; }
    public string VehicleModelName { get; set; }
    public int VehicleMakeId { get; set; }

    public virtual VehicleMake VehicleMake { get; set; }
    public virtual ICollection<Vehicle> Vehicles { get; set; }
  }
}
