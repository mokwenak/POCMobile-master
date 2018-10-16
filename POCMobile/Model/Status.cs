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
  public partial class Status
  {
   public Status()
    {
      this.Drivers = new HashSet<Driver>();
      this.Users = new HashSet<User>();
      this.Vehicles = new HashSet<Vehicle>();
    }

    public int StatusId { get; set; }
    public string StatusName { get; set; }

    public virtual ICollection<Driver> Drivers { get; set; }
    public virtual ICollection<User> Users { get; set; }
    public virtual ICollection<Vehicle> Vehicles { get; set; }
  }
}
