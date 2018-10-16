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
  public partial class VehicleType
  {
    public VehicleType()
    {
      this.Trips = new HashSet<Trip>();
      this.Vehicles = new HashSet<Vehicle>();
    }

    public int VehicleTypeId { get; set; }
    public string VehicleTypeName { get; set; }

    public virtual ICollection<Trip> Trips { get; set; }
    public virtual ICollection<Vehicle> Vehicles { get; set; }
  }
}
