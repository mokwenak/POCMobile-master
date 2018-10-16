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
  public partial class OffenceType
  {
    public OffenceType()
    {
      this.TripOffences = new HashSet<TripOffence>();
    }

    public int OffenceTypeId { get; set; }
    public string OffenceTypeName { get; set; }

    public virtual ICollection<TripOffence> TripOffences { get; set; }
  }
}
