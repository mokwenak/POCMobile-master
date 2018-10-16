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
  public partial class SupplyType
  {
    public SupplyType()
    {
      this.Vehicles = new HashSet<Vehicle>();
    }

    public int SupplyTypeId { get; set; }
    public string SupplyTypeName { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; }
  }
}
