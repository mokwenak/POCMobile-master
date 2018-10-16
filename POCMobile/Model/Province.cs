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
  public partial class Province
  {
    public Province()
    {
      this.Offices = new HashSet<Office>();
    }

    public int ProvinceId { get; set; }
    public string ProvinceName { get; set; }

    public virtual ICollection<Office> Offices { get; set; }
  }
}
