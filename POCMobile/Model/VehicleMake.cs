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
  public partial class VehicleMake
  {
    public VehicleMake()
    {
      this.VehicleModels = new HashSet<VehicleModel>();
    }

    public int VehicleMakeId { get; set; }
    public string VehicleMakeName { get; set; }

    public virtual ICollection<VehicleModel> VehicleModels { get; set; }
  }
}
