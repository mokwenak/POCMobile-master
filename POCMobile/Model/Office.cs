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
  public partial class Office
  {
    public Office()
    {
      this.Drivers = new HashSet<Driver>();
      this.Users = new HashSet<User>();
    }

    public int OfficeId { get; set; }
    public string OfficeName { get; set; }
    public int OfficeTypeId { get; set; }
    public int ProvinceId { get; set; }

    public virtual ICollection<Driver> Drivers { get; set; }
    public virtual OfficeType OfficeType { get; set; }
    public virtual Province Province { get; set; }
    public virtual ICollection<User> Users { get; set; }
  }
}
