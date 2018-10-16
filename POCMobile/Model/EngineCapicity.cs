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
  public partial class EngineCapicity
  {
    public EngineCapicity()
    {
      this.Vehicles = new HashSet<Vehicle>();
    }

    public int EngineCapicityId { get; set; }
    public string EngineCapicityName { get; set; }

    public virtual ICollection<Vehicle> Vehicles { get; set; }
  }
}
